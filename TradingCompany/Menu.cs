using DAL;
using DAL.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany
{
    public class Menu : ConnectionManager
    {
        public void ChooseTable()
        {
            Console.Clear();
            Console.WriteLine("Welcome to start page!\n\n");
            Console.WriteLine("What table you want to choose?\n1. Users\n2. Categories\n3. Items\n4. Reviews");
            Console.WriteLine("\nYour selection: ");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    {
                        ChooseActionForUsers();
                        break;
                    }

                case "2":
                    {
                        ChooseActionForCategories();
                        break;
                    }

                case "3":
                    {
                        ChooseActionForItems();
                        break;
                    }

                case "4":
                    {
                        ChooseActionForReviews();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3 or 4.");
                    break;
            }
        }

        public void ChooseActionForUsers() 
        {
            UserDal userDal = new UserDal();

            Console.Clear();
            Console.WriteLine("TABLE: USERS\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all users\n" +
                          "2. Get user by Id\n" +
                          "3. Get user by name of column\n" +
                          "4. Add user\n" +
                          "5. Edit info about user\n" +
                          "6. Delete user by Id\n" +
                          "7. Delete user by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            userDal.PrintListOfUsers(userDal.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            userDal.PrintUser(userDal.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            userDal.PrintListOfUsers(userDal.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("NAME: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("LOGIN: ");
                            string login = Console.ReadLine();

                            Console.WriteLine("PASSWORD: ");
                            string password = Console.ReadLine();

                            Console.WriteLine("AGE: ");
                            int age = Convert.ToInt32(Console.ReadLine());

                            User user = new User(name, login, password, age);
                            userDal.Insert(user);

                            Console.WriteLine("User succesfully inserted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            userDal.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("User succesfully updated :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            userDal.DeleteById(id);

                            Console.WriteLine("User succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            userDal.DeleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("User succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForUsers();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }

        public void ChooseActionForCategories()
        {
            CategoryDal categoryDal = new CategoryDal();

            Console.Clear();
            Console.WriteLine("TABLE: CATEGORIES\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all categories\n" +
                          "2. Get category by Id\n" +
                          "3. Get category by name of column\n" +
                          "4. Add category\n" +
                          "5. Edit info about category\n" +
                          "6. Delete category by Id\n" +
                          "7. Delete category by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\n");

                            categoryDal.PrintListOfCategories(categoryDal.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            categoryDal.PrintCategory(categoryDal.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            categoryDal.PrintListOfCategories(categoryDal.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\n");

                            Console.WriteLine("NAME: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("DESCRIPTION: ");
                            string desc = Console.ReadLine();

                            Category category = new Category(name, desc);
                            categoryDal.Insert(category);

                            Console.WriteLine("Category succesfully inserted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            categoryDal.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("Category succesfully updated :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            categoryDal.DeleteById(id);

                            Console.WriteLine("Category succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: CATEGORIES\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            categoryDal.DeleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("Category succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForCategories();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }

        public void ChooseActionForItems()
        {
            ItemDal itemDal = new ItemDal();

            Console.Clear();
            Console.WriteLine("TABLE: ITEMS\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all items\n" +
                          "2. Get item by Id\n" +
                          "3. Get item by name of column\n" +
                          "4. Add item\n" +
                          "5. Edit info about item\n" +
                          "6. Delete item by Id\n" +
                          "7. Delete item by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\n");

                            itemDal.PrintListOfItems(itemDal.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            itemDal.PrintItem(itemDal.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\nName of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            itemDal.PrintListOfItems(itemDal.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\n");

                            Console.WriteLine("NAME: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("DESCRIPTION: ");
                            string desc = Console.ReadLine();

                            Console.WriteLine("CATEGORY_ID: ");
                            int categId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("PRICE: ");
                            decimal price = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("IN_STOCK: ");
                            string inStock = Console.ReadLine();

                            Item item = new Item(name, desc, categId, price, inStock);
                            itemDal.Insert(item);
                            Console.WriteLine("Item succesfully inserted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            itemDal.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("Item succesfully updated :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            itemDal.DeleteById(id);

                            Console.WriteLine("Item succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ITEMS\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            itemDal.DeleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("Item succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForItems();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }

        public void ChooseActionForReviews()
        {
            ReviewDal reviewDal = new ReviewDal();

            Console.Clear();
            Console.WriteLine("TABLE: REVIEWS\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all reviews\n" +
                          "2. Get review by Id\n" +
                          "3. Get review by name of column\n" +
                          "4. Add review\n" +
                          "5. Edit info about review\n" +
                          "6. Delete review by Id\n" +
                          "7. Delete review by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\n");

                            reviewDal.PrintListOfReviews(reviewDal.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            reviewDal.PrintReview(reviewDal.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\nName of column: ");

                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            reviewDal.PrintListOfReviews(reviewDal.GetByFieldName(fieldName, text));

                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\n");

                            Console.WriteLine("USER_ID: ");
                            int userId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("ITEM_ID: ");
                            int itemId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("TEXT OF REVIEW: ");
                            string text = Console.ReadLine();

                            DateTime dateTime = DateTime.Now;

                            Review review = new Review(userId, itemId, text, dateTime);
                            reviewDal.Insert(review);

                            Console.WriteLine("Review succesfully inserted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            reviewDal.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("Review succesfully updated :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            reviewDal.DeleteById(id);

                            Console.WriteLine("Review succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: REVIEWS\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            reviewDal.DeleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("Review succesfully deleted :)");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseActionForReviews();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }
    }
}