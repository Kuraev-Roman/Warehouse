using System.Collections.ObjectModel;
using WarehouseData.Models;

namespace WarehouseData.Context
{
    public class ApplicationContext
    {
        public ObservableCollection<Organization> orgs;
        public ObservableCollection<Models.Warehouse> whs;
        public ObservableCollection<Category> categories;
        public ObservableCollection<Manufacturer> manufacturers;
        public ObservableCollection<Supplier> suppliers;

        public ApplicationContext()
        {
            orgs = new ObservableCollection<Organization>();
            whs = new ObservableCollection<Models.Warehouse>();
            categories = new ObservableCollection<Category>();
            manufacturers = new ObservableCollection<Manufacturer>();
            suppliers = new ObservableCollection<Supplier>();
            OrgsFill();
        }

        public void OrgsFill()
        {
            var cat1 = new Category { Id = 1, Name = "Электроника" };
            var cat2 = new Category { Id = 2, Name = "Бытовая химия" };
            var cat3 = new Category { Id = 3, Name = "Продукты питания" };
            categories.Add(cat1); categories.Add(cat2); categories.Add(cat3);

            var man1 = new Manufacturer { Id = 1, Name = "Samsung" };
            var man2 = new Manufacturer { Id = 2, Name = "Procter & Gamble" };
            var man3 = new Manufacturer { Id = 3, Name = "Nestlé" };
            manufacturers.Add(man1); manufacturers.Add(man2); manufacturers.Add(man3);

            var sup1 = new Supplier { Id = 1, Name = "ООО Техно" };
            var sup2 = new Supplier { Id = 2, Name = "ООО Химик" };
            var sup3 = new Supplier { Id = 3, Name = "ООО Продторг" };
            suppliers.Add(sup1); suppliers.Add(sup2); suppliers.Add(sup3);

            Organization org1 = new Organization("Рога и копыта, ООО");
            Organization org2 = new Organization("Пупкин и сыновья, ООО");

            Models.Warehouse wh1 = new Models.Warehouse("Склад Рогов и Копыт №1", "Там, за лесом.", org1.OrgId);
            Models.Warehouse wh2 = new Models.Warehouse("Склад Рогов и Копыт №2", "Там, за лесом.", org1.OrgId);
            Models.Warehouse wh3 = new Models.Warehouse("Склад Пупкина №1", "Там, за горой.", org2.OrgId);
            Models.Warehouse wh4 = new Models.Warehouse("Склад Пупкина №2", "Там, за горой.", org2.OrgId);

            wh1.products.Add(new Product { Article = "A001", Name = "Телевизор Samsung 55\"", Unit = "шт", Price = 45000, StockQuantity = 10, DiscountPercent = 5, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });
            wh1.products.Add(new Product { Article = "A002", Name = "Смартфон Samsung Galaxy", Unit = "шт", Price = 25000, StockQuantity = 25, DiscountPercent = 0, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });
            wh1.products.Add(new Product { Article = "A003", Name = "Планшет Samsung Tab", Unit = "шт", Price = 35000, StockQuantity = 8, DiscountPercent = 3, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });

            wh2.products.Add(new Product { Article = "B001", Name = "Стиральный порошок Tide", Unit = "кг", Price = 350, StockQuantity = 100, DiscountPercent = 10, Category = cat2, Manufacturer = man2, Supplier = sup2, CategoryId = 2, ManufacturerId = 2, SupplierId = 2 });
            wh2.products.Add(new Product { Article = "B002", Name = "Гель для посуды Fairy", Unit = "шт", Price = 120, StockQuantity = 200, DiscountPercent = 5, Category = cat2, Manufacturer = man2, Supplier = sup2, CategoryId = 2, ManufacturerId = 2, SupplierId = 2 });
            wh2.products.Add(new Product { Article = "B003", Name = "Кондиционер Lenor", Unit = "шт", Price = 280, StockQuantity = 80, DiscountPercent = 0, Category = cat2, Manufacturer = man2, Supplier = sup2, CategoryId = 2, ManufacturerId = 2, SupplierId = 2 });

            wh3.products.Add(new Product { Article = "C001", Name = "Ноутбук Samsung", Unit = "шт", Price = 65000, StockQuantity = 5, DiscountPercent = 0, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });
            wh3.products.Add(new Product { Article = "C002", Name = "Монитор Samsung 27\"", Unit = "шт", Price = 28000, StockQuantity = 8, DiscountPercent = 7, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });
            wh3.products.Add(new Product { Article = "C003", Name = "Клавиатура Samsung", Unit = "шт", Price = 3500, StockQuantity = 20, DiscountPercent = 0, Category = cat1, Manufacturer = man1, Supplier = sup1, CategoryId = 1, ManufacturerId = 1, SupplierId = 1 });

            wh4.products.Add(new Product { Article = "D001", Name = "Кофе Nescafé Gold", Unit = "шт", Price = 450, StockQuantity = 150, DiscountPercent = 0, Category = cat3, Manufacturer = man3, Supplier = sup3, CategoryId = 3, ManufacturerId = 3, SupplierId = 3 });
            wh4.products.Add(new Product { Article = "D002", Name = "Шоколад Nestlé Kit Kat", Unit = "шт", Price = 85, StockQuantity = 300, DiscountPercent = 5, Category = cat3, Manufacturer = man3, Supplier = sup3, CategoryId = 3, ManufacturerId = 3, SupplierId = 3 });

            org1.warehouses.Add(wh1); org1.warehouses.Add(wh2);
            org2.warehouses.Add(wh3); org2.warehouses.Add(wh4);
            orgs.Add(org1); orgs.Add(org2);
        }
    }
}