using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft
{
    class CommandsSql
    {
                                                                            //***MENU CLIENTS FORM***//

        public static string insert_cl()
        {
            string ins_cl = "INSERT INTO [clients] (Id, FirstName, LastName, MiddleName, Phone, Email) VALUES(@Id, @FirstName, @LastName, @MiddleName, @Phone, @Email)";
            return ins_cl;
        }
        public static string upd_cl()
        {
            string upd_cl = "UPDATE [clients] SET [Id]=@Id, [FirstName]=@FirstName, [LastName]=@LastName, [MiddleName]=@MiddleName, [Phone]=@Phone, [Email]=@Email " +
                "WHERE [Id]=@Id";
            return upd_cl;
        }
        public static string check_id_dem_sup(string box)
        {
            string check = "SELECT t1.ClientId FROM supplies as t1 WHERE ClientId='"+box+"' " +
                "union SELECT t2.ClientId FROM[dbo].[apartment_demands] as t2 WHERE ClientId='" + box + "' " +
                "union SELECT t3.ClientId FROM[dbo].[house_demands] as t3 WHERE ClientId='" + box + "' " +
                "union SELECT t4.ClientId FROM[dbo].[land_demands] as t4 WHERE ClientId='" + box + "'";
            return check;
        }


                                                                            //***MENU RIELTORS FORM***//

        public static string check_id_dem_sup_ag(string box)
        {
            string check = "SELECT t1.AgentId FROM supplies as t1 WHERE AgentId='" + box + "' " +
                "union SELECT t2.AgentId FROM[dbo].[apartment_demands] as t2 WHERE AgentId='" + box + "' " +
                "union SELECT t3.AgentId FROM[dbo].[house_demands] as t3 WHERE AgentId='" + box + "' " +
                "union SELECT t4.AgentId FROM[dbo].[land_demands] as t4 WHERE Agent" +
                "Id='" + box + "'";
            return check;
        }
        public static string insert_ag()
        {
            string ins_ag = "INSERT INTO [agents] (Id, FirstName, LastName, MiddleName, DealShare) VALUES(@Id, @FirstName, @LastName, @MiddleName, @DealShare" +
                ")";
            return ins_ag;
        }
        public static string upd_ag()
        {
            string upd_ag = "UPDATE [agents] SET [Id]=@Id, [FirstName]=@FirstName, [LastName]=@LastName, [MiddleName]=@MiddleName, [DealShare]=@DealShare WHERE [Id]=@Id";
            return upd_ag;
        }


                                                                            //***NEDVIZHIMOST FORM***//

        //Check in supplies
        public static string check_id_sup(string box)
        {
            string check = "SELECT RealEstateId FROM supplies WHERE RealEstateId In" +
                "(SELECT t1.Id FROM apartments as t1 WHERE Id = '"+box+"' union " +
                "SELECT t2.Id FROM houses as t2 WHERE Id = '" + box + "' union " +
                "SELECT t3.Id FROM lands as t3 WHERE Id = '" + box + "')";
            return check;
        }
        //Check id in tables all
        public static string check_id_ahl(string box)
        {
            string check = "SELECT t1.Id FROM apartments as t1 WHERE Id = '" + box + "' union " +
                "SELECT t2.Id FROM houses as t2 WHERE Id = '" + box + "' union " +
                "SELECT t3.Id FROM lands as t3 WHERE Id = '" + box + "'";
            return check;
        }
        //check id in apartments
        public static string check_id_ap(string box)
        {
            string check = "SELECT Id FROM apartments WHERE Id = '" + box + "'";
            return check;
        }
        //check id in houses
        public static string check_id_houses(string box)
        {
            string check = "SELECT Id FROM houses WHERE Id = '" + box + "'";
            return check;
        }
        //check id in lands
        public static string check_id_lands(string box)
        {
            string check = "SELECT Id FROM lands WHERE Id = '" + box + "'";
            return check;
        }

        //Find object
        public static string find_obj(string width, string length)
        {
            string find = "SELECT Id,Address_City,Address_Street,Address_House FROM apartments WHERE (Coordinate_latitude between '"+width+"' and '"+length+ "') and (Coordinate_longitude between '" + width + "' and '" + length + "') " +
                "union " +
                "SELECT Id,Address_City,Address_Street,Address_House FROM houses WHERE (Coordinate_latitude between '" + width + "' and '" + length + "') and (Coordinate_longitude between '" + width + "' and '" + length + "') " +
                "union " +
                "SELECT Id,Address_City,Address_Street,Address_House FROM lands WHERE (Coordinate_latitude between '" + width + "' and '" + length + "') and (Coordinate_longitude between '" + width + "' and '" + length + "')";
            return find;
        }
        //Filter
        public static string filter_objects()
        {
            string filter = "select Id, Address_City, Address_Street, Address_House, Address_Number from apartments union " +
                "select Id, Address_City, Address_Street, Address_House, Address_Number from houses union " +
                "select Id, Address_City, Address_Street, Address_House, Address_Number from lands";
                
            return filter;
        }

        //INSERTS
        public static string InsertApartment()
        {
            string InsertApartment = "INSERT INTO [apartments] (Id, Address_City, Address_Street, Address_House, Address_Number, Coordinate_latitude," +
            "Coordinate_longitude,TotalArea, Rooms, Floor) " +
            "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @Coordinate_latitude," +
            "@Coordinate_longitude, @TotalArea, @Rooms, @Floor)";
            return InsertApartment;
        }
        public static string InsertHouses()
        {
            string InsertHouses = "INSERT INTO [houses] (Id, Address_City, Address_Street, Address_House, Address_Number, Coordinate_latitude," +
            "Coordinate_longitude,TotalFloors, TotalArea) " +
            "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @Coordinate_latitude," +
            "@Coordinate_longitude, @TotalFloors, @TotalArea)";
            return InsertHouses;
        }
        public static string InsertLands()
        {
            string InsertLands = "INSERT INTO [lands] (Id, Address_City, Address_Street, Address_House, Address_Number, Coordinate_latitude," +
            "Coordinate_longitude,TotalArea) " +
            "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @Coordinate_latitude," +
            "@Coordinate_longitude, @TotalArea)";
            return InsertLands;
        }

        //UPDATES
        public static string UpdateApartment()
        {
            string UpdateApartment = "Update [apartments] Set Address_City=@Address_City, Address_Street=@Address_Street, Address_House=@Address_House, " +
            "Address_Number=@Address_Number, Coordinate_latitude=@Coordinate_latitude, Coordinate_longitude=@Coordinate_longitude,TotalArea=@TotalArea, Rooms=@Rooms,"+
            "Floor=@Floor where Id=@Id";
            return UpdateApartment;
        }
        public static string UpdateHouses()
        {
            string UpdateHouses = "Update [houses] Set Address_City=@Address_City, Address_Street=@Address_Street, Address_House=@Address_House, " +
            "Address_Number=@Address_Number, Coordinate_latitude=@Coordinate_latitude, Coordinate_longitude=@Coordinate_longitude,TotalFloors=@TotalFloors," +
            "TotalArea=@TotalArea where Id=@Id";
            return UpdateHouses;
        }
        public static string UpdateLands()
        {
            string UpdateLands = "Update [lands] Set Address_City=@Address_City, Address_Street=@Address_Street, Address_House=@Address_House, " +
           "Address_Number=@Address_Number, Coordinate_latitude=@Coordinate_latitude, Coordinate_longitude=@Coordinate_longitude,TotalArea=@TotalArea where Id=@Id";
            return UpdateLands;
        }


                                                                            //***SUPPLIES FORM***//
        //Fill comboBox of id on Supplies form
        public static string fill_ID_CB_type_objects()
        {
            string select_id_cb = "select t1.Id from apartments as t1 union select t2.Id from houses as t2 union select t3.Id from lands as t3";
            return select_id_cb;
        }
        public static string fill_ID_CB_agents()
        {
            string idAg = "select Id from agents";
            return idAg;
        }
        public static string fill_ID_CB_clients()
        {
            string idCl = "select Id from clients";
            return idCl;
        }

        //Insert in Supplies
        public static string insert_supply()
        {
            string into_supl = "INSERT INTO [Supplies] (Id, Price, AgentId, ClientId, RealEstateId) VALUES(@Id,@Price,@AgentId,@ClientId,@RealEstateId)";
            return into_supl;
        }
        //Update in Supplies
        public static string update_supply()
        {
            string upd_supl = "UPDATE Supplies SET [Price]=@Price,[AgentId]=@AgentId,[ClientId]=@ClientId,[RealEstateId]=@RealEstateId WHERE [Id]=@Id";
            return upd_supl;
        }


        
                                                                            //***DEMANDS FORM***//

        //select of city in cb
        public static string selcity()
        {
            string sc= "SELECT t1.Address_City from [apartments] as t1 union SELECT t2.Address_City from [houses] as t2 " +
                "union SELECT t3.Address_City from [lands] as t3";
            return sc;
        }

        //Select Insert, Update buttons

        //checking Id in demands(3 tables) for delete or find unknown Id
        public static string check_id(string box)
        {
            string check = "SELECT t1.Id FROM apartment_demands as t1 WHERE Id='"+box+"' union SELECT t2.Id FROM house_demands as t2 WHERE Id ='"+box+"' " +
                "union SELECT t3.Id FROM land_demands as t3 WHERE Id = '"+box+"'";
            return check;
        }

        //INSERTS

        //Into demand_apartment
        public static string insert_d_apart()
        {
            string insert1 = "INSERT INTO [apartment_demands] " +
                "(Id, Address_City, Address_Street, Address_House, Address_Number, MinPrice, MaxPrice, AgentId, ClientId, MinArea, MaxArea, MinRooms, MaxRooms, MinFloor, MaxFloor) " +
                "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @MinPrice, @MaxPrice, @AgentId, @ClientId, @MinArea, @MaxArea, @MinRooms, @MaxRooms, @MinFloor, @MaxFloor)";
            return insert1;
        }
        //Into demand_house
        public static string insert_d_house()
        {
            string insert2 = "INSERT INTO [house_demands] " +
                "(Id, Address_City, Address_Street, Address_House, Address_Number, MinPrice, MaxPrice, AgentId, ClientId, MinFloors, MaxFloors, MinArea, MaxArea, MinRooms, MaxRooms) " +
                "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @MinPrice, @MaxPrice, @AgentId, @ClientId, @MinFloors, @MaxFloors, @MinArea, @MaxArea, @MinRooms, @MaxRooms)";
            return insert2;
        }
        //Into demand_land
        public static string insert_d_land()
        {
            string insert3 = "INSERT INTO [land_demands] (Id, Address_City, Address_Street, Address_House, Address_Number, MinPrice, MaxPrice, AgentId, ClientId, MinArea, MaxArea) " +
                "VALUES(@Id, @Address_City, @Address_Street, @Address_House, @Address_Number, @MinPrice, @MaxPrice, @AgentId, @ClientId, @MinArea, @MaxArea)";
            return insert3;
        }

        //UPDATES

        //Update_apartments
        public static string upd_d_apart()
        {
            string upd1 = "UPDATE apartment_demands SET [Id]=@Id, [Address_City]=@Address_City, [Address_Street]=@Address_Street, [Address_House]=@Address_House, " +
                "[Address_Number]=@Address_Number, [MinPrice]=@MinPrice, [MaxPrice]=@MaxPrice, [AgentId]=@AgentId, [ClientId]=@ClientId, [MinArea]=@MinArea, " +
                "[MaxArea]=@MaxArea, [MinRooms]=@MinRooms, [MaxRooms]=@MaxRooms, [MinFloor]=@MinFloor, [MaxFloor]=@MaxFloor WHERE [Id]=@Id";
            return upd1;
        }
        //Update_houses
        public static string upd_d_house()
        {
            string upd1 = "UPDATE house_demands SET [Id]=@Id, [Address_City]=@Address_City, [Address_Street]=@Address_Street, [Address_House]=@Address_House, " +
                "[Address_Number]=@Address_Number, [MinPrice]=@MinPrice, [MaxPrice]=@MaxPrice, [AgentId]=@AgentId, [ClientId]=@ClientId, [MinArea]=@MinArea, [MinFloors]=@MinFloors, " +
                "[MaxFloors]=@MaxFloors, [MaxArea]=@MaxArea, [MinRooms]=@MinRooms, [MaxRooms]=@MaxRooms WHERE [Id]=@Id";
            return upd1;
        }
        //Update_lands
        public static string upd_d_land()
        {
            string upd1 = "UPDATE land_demands SET [Id]=@Id, [Address_City]=@Address_City, [Address_Street]=@Address_Street, [Address_House]=@Address_House, " +
                "[Address_Number]=@Address_Number, [MinPrice]=@MinPrice, [MaxPrice]=@MaxPrice, [AgentId]=@AgentId, [ClientId]=@ClientId, [MinArea]=@MinArea, " +
                "[MaxArea]=@MaxArea WHERE [Id]=@Id";
            return upd1;
        }


                                                                        //***DEALS FORM***//
        
        //select id demands from 3 tables
        public static string select_id_demands()
        {
            string select_id = "SELECT t1.Id FROM apartment_demands as t1 " +
                "union " +
                "SELECT t2.Id FROM house_demands as t2 " +
                "union " +
                "SELECT t3.Id FROM land_demands as t3";
            return select_id;
        }
        //check id demands(3)
        public static string check_id_demands(string box)
        {
            string check_id = "select t1.Id From apartment_demands as t1 where Id = "+box+" union " +
                "select t2.Id From house_demands as t2 where Id = "+box+" union " +
                "select t3.Id From land_demands as t3 where Id = "+box+"";
            return check_id;
        }

        //comission of rb
        public static string cRb(string box)
        {
            string crb = "SELECT Top 1 (Price * 0.03) * (DealShare*0.01) as comissiyaRieltora, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='"+box+"'";
            return crb;
        }
        //comission of company
        public static string company(string box)
        {
            string cms = "SELECT Top 1 (Price * 0.03) * (DealShare*0.01) as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }
        //comission of company
        public static string company_null_rieltor(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }

        //CUSTOMER

        //comission of customer where % realtor have null for appartments
        public static string cmsNullbuyer_ap(string box)
        {
            string cms = "SELECT TOP 1 (Price*0.01)+36000 as comissiyaP,((Price*0.01)+36000) *0.45 as comissiyaAgenta " +
                                    "FROM supplies, deals as t1 WHERE t1.Id ='" + box + "'";
            return cms;
        }
        //comission of relator where % realtor have null for appartments
        public static string cmsNull1(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }

        //comission of customer where % realtor have null for houses
        public static string cmsNullbuyer_ho(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }
        //comission of relator where % realtor have null for houses
        public static string cmsNull2(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }

        //comission of customer where % realtor have null for lands
        public static string cmsNullbuyer_la(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }
        //comission of relator where % realtor have null for lands
        public static string cmsNull3(string box)
        {
            string cms = "SELECT Top 1(Price * 0.03) * 0.45 as comissiyaRieltora, " +
                            "(Price * 0.03) - (Price * 0.03) * (DealShare * 0.01) as Company, ClientId " +
                            "FROM supplies as t1, deals, agents WHERE t1.Id ='" + box + "'";
            return cms;
        }
    }
}
