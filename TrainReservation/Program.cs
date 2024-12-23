using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace TrainReservationApp

{

    public class TrainReservationSystem

    {

        private static string connectionString = "Data Source=ICS-LT-D244D6CV\\SQLEXPRESS;Initial Catalog=TrainReservation;Integrated Security=True";

  
        public void Run()

        {

            while (true)

            {

                Console.WriteLine("1. Admin");

                Console.WriteLine("2. User");

                Console.WriteLine("3. Exit");

                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        AdminMenu();

                        break;

                    case "2":

                        Program.RegisterUser();
                        UserMenu();

                        break;

                    case "3":

                        return;

                    default:

                        Console.WriteLine("Invalid option. Try again.");

                        break;

                }

            }

        }




        private void AdminMenu()

        {

            while (true)

            {

                Console.WriteLine("\nAdmin Menu:");

                Console.WriteLine("1. Add Trains");

                Console.WriteLine("2. Modify Trains");

                Console.WriteLine("3. Delete Trains ");

                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        AddTrain();

                        break;

                    case "2":

                        ModifyTrain();

                        break;

                    case "3":

                        DeleteTrain();

                        break;

                    case "4":

                        return;

                    default:

                        Console.WriteLine("Invalid option. Try again.");

                        break;

                }

            }

        }

        private void UserMenu()

        {

            while (true)

            {

                Console.WriteLine("\nUser Menu:");

                Console.WriteLine("1. Book Tickets");

                Console.WriteLine("2. Cancel Tickets");

                Console.WriteLine("3. Show All Trains");

                Console.WriteLine("4. Show Booking/Cancellation");

                Console.WriteLine("5. Exit");

                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        BookTickets();

                        break;

                    case "2":

                        CancelTickets();

                        break;

                    case "3":

                        ShowAllTrains();

                        break;

                    case "4":

                        ShowBookingCancellation();

                        break;

                    case "5":

                        return;

                    default:

                        Console.WriteLine("Invalid option. Try again.");

                        break;

                }

            }

        }

        private void AddTrain()

        {

            Console.Write("Enter Train No: ");

            int trainNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Train Name: ");

            string trainName = Console.ReadLine();

            Console.Write("Enter Class (1st Class/Second Class/Sleeper): ");

            string trainClass = Console.ReadLine();

            Console.Write("Enter Total Berths: ");

            int totalBerths = int.Parse(Console.ReadLine());

            Console.Write("Enter Source: ");

            string source = Console.ReadLine();

            Console.Write("Enter Destination: ");

            string destination = Console.ReadLine();

            Console.Write("Enter Price Per Seat: ");

            decimal pricePerSeat = decimal.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand("AddTrain", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TrainNo", trainNo);

                cmd.Parameters.AddWithValue("@TrainName", trainName);

                cmd.Parameters.AddWithValue("@Class", trainClass);

                cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);

                cmd.Parameters.AddWithValue("@Source", source);

                cmd.Parameters.AddWithValue("@Destination", destination);

                cmd.Parameters.AddWithValue("@PricePerSeat", pricePerSeat);

                conn.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Train added successfully.");

            }

        }

        private void ModifyTrain()

        {

            Console.Write("Enter Train No to Modify: ");

            int trainNo = int.Parse(Console.ReadLine());

            Console.Write("Enter New Train Name: ");

            string trainName = Console.ReadLine();

            Console.Write("Enter New Class (1st Class/2nd Class/Sleeper): ");

            string trainClass = Console.ReadLine();

            Console.Write("Enter New Total Berths: ");

            int totalBerths = int.Parse(Console.ReadLine());

            Console.Write("Enter New Source: ");

            string source = Console.ReadLine();

            Console.Write("Enter New Destination: ");

            string destination = Console.ReadLine();

            Console.Write("Enter New Price Per Seat: ");

            decimal pricePerSeat = decimal.Parse(Console.ReadLine());

            Console.Write("Is Train Active? (true/false): ");

            bool isActive = bool.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(TrainReservationSystem.connectionString))

            {

                SqlCommand cmd = new SqlCommand("ModifyTrain", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TrainNo", trainNo);

                cmd.Parameters.AddWithValue("@TrainName", trainName);

                cmd.Parameters.AddWithValue("@Class", trainClass);

                cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);

                cmd.Parameters.AddWithValue("@Source", source);

                cmd.Parameters.AddWithValue("@Destination", destination);

                cmd.Parameters.AddWithValue("@PricePerSeat", pricePerSeat);

                cmd.Parameters.AddWithValue("@IsActive", isActive);

                conn.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Train modified successfully.");

            }

        }

        private void DeleteTrain()

        {

            Console.Write("Enter Train No to Delete: ");

            int trainNo = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand("DeleteTrain", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TrainNo", trainNo);

                conn.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Train deactivated successfully.");

            }

        }

        private void BookTickets()

        {

            Console.Write("Enter User ID: ");

            int userId = int.Parse(Console.ReadLine());

            Console.Write("Enter Train No: ");

            int trainNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Class (1st Class/2nd Class/Sleeper): ");

            string trainClass = Console.ReadLine();

            Console.Write("Enter Number of Berths to Book: ");

            int berths = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand("BookTickets", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", userId);

                cmd.Parameters.AddWithValue("@TrainNo", trainNo);

                cmd.Parameters.AddWithValue("@Class", trainClass);

                cmd.Parameters.AddWithValue("@Berths", berths);

                conn.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Tickets booked successfully.");

            }

        }

     

        private void CancelTickets()

        {

            Console.Write("Enter Booking ID: ");

            int bookingId = int.Parse(Console.ReadLine());


            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    int trainNo;
                    string trainClass;
                    int berthsBooked;
                    decimal pricePerSeat;
                    decimal refundAmount;
                    // Fetch booking details
                    string fetchBookingQuery = @"
                            SELECT TrainNo, Class, BerthsBooked
                            FROM Bookings
                            WHERE BookingID = @BookingID";
                    using (SqlCommand fetchBookingCmd = new SqlCommand(fetchBookingQuery, connection, transaction))
                    {
                        fetchBookingCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        using (SqlDataReader reader = fetchBookingCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                Console.WriteLine("Invalid booking ID.");
                                return;
                            }
                            trainNo = reader.GetInt32(0);
                            trainClass = reader.GetString(1);
                            berthsBooked = reader.GetInt32(2);
                        }
                    }
                    // Update available berths
                    string updateTrainsQuery = @"
                            UPDATE Trains
                            SET AvailableBerths = AvailableBerths + @BerthsBooked
                            WHERE TrainNo = @TrainNo AND Class = @Class";
                    using (SqlCommand updateTrainsCmd = new SqlCommand(updateTrainsQuery, connection, transaction))
                    {
                        updateTrainsCmd.Parameters.AddWithValue("@BerthsBooked", berthsBooked);
                        updateTrainsCmd.Parameters.AddWithValue("@TrainNo", trainNo);
                        updateTrainsCmd.Parameters.AddWithValue("@Class", trainClass);
                        updateTrainsCmd.ExecuteNonQuery();
                    }
                    // Calculate refund amount
                    string fetchPriceQuery = @"
                            SELECT PricePerSeat
                            FROM Trains
                            WHERE TrainNo = @TrainNo";
                    using (SqlCommand fetchPriceCmd = new SqlCommand(fetchPriceQuery, connection, transaction))
                    {
                        fetchPriceCmd.Parameters.AddWithValue("@TrainNo", trainNo);
                        pricePerSeat = (decimal)fetchPriceCmd.ExecuteScalar();
                    }
                    refundAmount = berthsBooked * pricePerSeat;

                    // Insert cancellation record
                    string insertCancellationQuery = @"
                            INSERT INTO Cancellations (BookingID, RefundAmount)
                            VALUES (@BookingID, @RefundAmount)";
                    using (SqlCommand insertCancellationCmd = new SqlCommand(insertCancellationQuery, connection, transaction))
                    {
                        insertCancellationCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        insertCancellationCmd.Parameters.AddWithValue("@RefundAmount", refundAmount);
                        insertCancellationCmd.ExecuteNonQuery();
                    }
                    // Delete Cancellation Record
                    string deleteCancellationsQuery = @"
                                DELETE FROM Cancellations
                                WHERE BookingID = @BookingID";
                    using (SqlCommand deleteCancellationsCmd = new SqlCommand(deleteCancellationsQuery, connection, transaction))
                    {
                        deleteCancellationsCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        deleteCancellationsCmd.ExecuteNonQuery();
                    }



                    // Delete booking record
                    string deleteBookingQuery = @"
                             DELETE FROM Bookings
                             WHERE BookingID = @BookingID";
                    using (SqlCommand deleteBookingCmd = new SqlCommand(deleteBookingQuery, connection, transaction))
                    {
                        deleteBookingCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        deleteBookingCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    Console.WriteLine($"Cancellation successful. Refund amount: {refundAmount:C}");

                    
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            




        }

      



        private void ShowAllTrains()

        {

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand("CheckTrainAvailability", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())

                {

                    Console.WriteLine("Available Trains:");

                    while (reader.Read())

                    {

                        Console.WriteLine($"TrainNo: {reader["TrainNo"]}, TrainName: {reader["TrainName"]}, Class: {reader["Class"]}, Source: {reader["Source"]}, Destination: {reader["Destination"]}, Available Berths: {reader["AvailableBerths"]}, Price: {reader["PricePerSeat"]}");

                    }

                }

            }

        }

        private void ShowBookingCancellation()

        {

            Console.Write("Enter User ID: ");

            int userId = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand("ShowBookingCancellation", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())

                {

                    Console.WriteLine("Booking/Cancellation Details:");

                    while (reader.Read())

                    {

                        Console.WriteLine($"BookingID: {reader["BookingID"]}, TrainNo: {reader["TrainNo"]}, Class: {reader["Class"]}, BerthsBooked: {reader["BerthsBooked"]}, BookingDate: {reader["BookingDate"]}, CancellationDate: {reader["CancellationDate"]}, RefundAmount: {reader["RefundAmount"]}");

                    }

                }

            }

        }

        class Program
        {

            private readonly string _connectionString;


            public Program()
            {
                _connectionString = connectionString;
            
            }
            static void Main(string[] args)
            {
                Console.WriteLine("=============================================================================================================================");
                Console.WriteLine("                                                        **  IRCTC  **                                                        ");
                Console.WriteLine("=============================================================================================================================");


                TrainReservationSystem system = new TrainReservationSystem();
                system.Run();

                Program.RegisterUser();

               
            }


            public static void RegisterUser()
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                string authenticateQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(authenticateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);
                            int userCount = (int)cmd.ExecuteScalar();
                            if (userCount > 0)
                            {
                                Console.WriteLine("Authentication successful. Welcome, " + username + "!");
                            }
                            else
                            {
                                Console.WriteLine("Authentication failed. Invalid username or password.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }




            }


           
        }

    }
}

