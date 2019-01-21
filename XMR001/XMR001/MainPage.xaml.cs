using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.IO;
using System.Diagnostics;

namespace XMR001
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("버튼이 눌러졌습니다. ");
            await Navigation.PushAsync(new ScoreBoard());

            //DoSomeDataAccess();
            //DBFullScan();
        }
        public static void DBFullScan()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            if(db.Table<Stock>().Count() != 0)
            {
                //var table = db.Table<Stock>();
                var table = db.Query<Stock>("SELECT * FROM Items WHERE Symbol like 'MSFT%'");
                foreach (var s in table)
                {
                    Debug.Print(s.Id + " " + s.Symbol);
                }
            }
        }
        [Table("Items")]
        public class Stock
        {
            [PrimaryKey, AutoIncrement, Column("id")]
            public int Id { get; set; }
            [MaxLength(8)]
            public string Symbol { get; set; }
        }
        public static void DoSomeDataAccess()
        {
            Debug.Print("Creating database, if it doesn't already exist");
            //onsole.WriteLine("Creating database, if it doesn't already exist");
            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            
            db.CreateTable<Stock>();
            if (db.Table<Stock>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newStock = new Stock();
                newStock.Symbol = "AAPL";
                db.Insert(newStock);

                newStock = new Stock();
                newStock.Symbol = "GOOG";
                db.Insert(newStock);

                newStock = new Stock();
                newStock.Symbol = "MSFT";
                db.Insert(newStock);
            }
            else
            {
                var newStock = new Stock();
                newStock = new Stock();
                newStock.Symbol = "MSFT_"+ db.Table<Stock>().Count();
                db.Insert(newStock);
                Debug.Print("Data Count " + (db.Table<Stock>().Count()));
            }
            Debug.Print("Reading data");
            //System.Console.WriteLine("Reading data");
            var table = db.Table<Stock>();
            foreach (var s in table)
            {
                Debug.Print(s.Id + " " + s.Symbol);
                //System.Console.WriteLine(s.Id + " " + s.Symbol);
            }
            Debug.Print("Test" + table);
            //System.Console.WriteLine("Test" + table);
        }
    }

}