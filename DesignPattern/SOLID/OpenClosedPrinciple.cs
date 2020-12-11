using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SOLID
{
    class OpenClosedPrinciple
    {
        public static void TestOpenClosedPrinciple()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] p = { apple, tree, house };
            var pf = new ProductFilter();
            Console.WriteLine( "Green product(old)");
            foreach (var item in pf.FilterBySize(p, Size.Small))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Size);
            }
            var bf = new BetterFilter();
            Console.WriteLine("Green product(new)");
            foreach (var item in bf.Filter(p, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Size);
            }

            foreach (var item in bf.Filter(p, new EndSpecification<Product>(
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
                )))
            {
                Console.WriteLine($"- {item.Name} is large and blue");
            }
        } 
    }

    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public interface ISpecification<T>
    {
        bool IsSatisified(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> t, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatisified(Product t)
        {
            return t.Color == color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisified(Product t)
        {
            return t.Size == size;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
                if (spec.IsSatisified(item))
                    yield return item;
        }
    }


    public class EndSpecification<T> : ISpecification<T>
    {
        ISpecification<T> first, second;
        public EndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisified(T t)
        {
            return first.IsSatisified(t) && second.IsSatisified(t);
        }
    }

    public  class ProductFilter
    {
        // Method to filter by Color
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
                if (product.Size == size)
                    yield return product;
        }

        // Method Filter by Size
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
                if (product.Color == color)
                    yield return product;
        }

        // Method for Filter By Color and size
        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var product in products)
                if (product.Color == color && product.Size == size)
                    yield return product;
        }
    }
}
