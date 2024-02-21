using MyFirstMobileApp.Models.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.DataAccess
{
    public class SQLiteImplementation
    {
        //SQLiteAsyncConnection: Is a class provided by SQLite-net to facilitate asynchronous database operations.
        //con: This is a variable name chosen to represent the SQLite database connection.
        SQLiteAsyncConnection con;

        public SQLiteImplementation()
        {
            //Initialize and sets up the database. The method is async, as a result
            //we ignore any return value by using the discard symbole "_" which tells
            //the compiler that the result of the method is intentionally being ignored.
            //This can be useful when you have a method that returns a value,
            //but you don't need that value for the current operation.
            _ = InitializeDatabase();
        }

        //Method to get a connection to SQLite database with table creation
        private async Task InitializeDatabase()
        {
            if (con == null)
            {
                //Set the database file name
                string fileName = DbaseNames.CarDB;

                //Get the path to the personal folder on the device
                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                //Combine the document path and file name to get the complete path
                string path = Path.Combine(documentPath, fileName);

                //Check if the directory exists, create it if it doesn't
                if (!File.Exists(path))
                {
                    //Create the directory if it doesn't exist
                    Directory.CreateDirectory(documentPath);
                }

                //Initialize SQLite connection
                con = new SQLiteAsyncConnection(path);

                //Create 'Car' table if it does not exist
                await con.CreateTableAsync<Car>();
            }
        }

        //Method to retrieve all cars from the 'Car' table
        public async Task<List<Car>> GetCar()
        {
            //Use the returned connection from InitializeDatabase
            await InitializeDatabase();

            //SQL query to select all rows from 'Car' table
            string sql = "SELECT * FROM Car";

            //Execute the query and retrieve a list of vacations
            List<Car> cars = await con.QueryAsync<Car>(sql);

            return cars;
        }

        //Method to save a new car record
        public async Task<string> SaveCar(Car car)
        {
            string result = string.Empty;

            try
            {
                await InitializeDatabase();

                //Check if a record with the same Brand and Color already exists
                var existingCar = await con.Table<Car>()
                        .Where(c => c.Brand == car.Brand && c.Color == car.Color)
                        .FirstOrDefaultAsync();

                if (existingCar == null)
                {
                    //Insert the car record into the 'Car' table
                    await con.InsertAsync(car);
                }
                else
                {
                    //Record with the same Brand and Color already exists
                    string msg = car.Brand + " and " + car.Color + " already exists.";
                    //await Application.Current.MainPage.DisplayAlert("Message", msg, "Ok");

                    result = msg;
                }
            }
            catch (Exception ex)
            {
                result = "ERROR: " + ex.Message;
            }

            return result;
        }

        //Method to update an existing car record
        public async Task<bool> UpdateCar(Car car)
        {
            bool res = false;

            try
            {
                //Use the returned connection from InitializeDatabase
                await InitializeDatabase();

                //$ is short-hand for String.Format, used with string 
                //interpolations (e.g. {0}).  Used in C# 6.0
                //SQL query to update car details based on the provided Id
                string sql = $"UPDATE Vacation " +
                                  $"SET Brand = '{car.Brand}', " +
                                  $"Color = '{car.Color}', " +
                                  $"Miles = '{car.Miles}' " +
                                  $"WHERE Id = {car.Id}";

                //Execute the update query
                await con.QueryAsync<Car>(sql);
                res = true;
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }

            return res;
        }

        //Method to delete a car record based on the provided Id
        public async Task<bool> DeleteCar(int Id)
        {
            bool res = false;

            try
            {
                //Use the returned connection from InitializeDatabase
                await InitializeDatabase();

                /*****************************************************************************
                 * A SQL query is not the correct usage for deleting records based on their primary key. 
                 * For deleting a record by its primary key, DeleteAsync expects the actual object or 
                 * the primary key value, not an SQL query.
                 ******************************************************************************/
                var carToDelete = await con.Table<Car>().FirstOrDefaultAsync(c => c.Id == Id);

                if (carToDelete != null)
                {
                    //Delete the retrieved car
                    await con.DeleteAsync(carToDelete);
                    res = true;
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions
                res = false;
            }

            return res;
        }

    }
}
