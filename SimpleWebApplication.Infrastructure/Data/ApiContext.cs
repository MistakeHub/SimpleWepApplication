using Microsoft.EntityFrameworkCore;
using SimpleWebApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Infrastructure.Data
{
    public class ApiContext:DbContext
    {

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employe> Employees { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Note> Notes { get; set; }

   


        public ApiContext(DbContextOptions options):base(options) {

          
        }

        public void Seed()
        {
            if(Companies.Count() == 0)
            {
                Employe employe = new Employe() { FirstName = "John", LastName="Heart", BirthDate=new DateTime(1974,12,12), Title="Mr", Position="CEO"};
                Employe employe2 = new Employe() { FirstName = "Olivia", LastName = "Peyton", BirthDate = new DateTime(1965, 12, 09), Title = "Mrs", Position = "CEO" };
                Employe employe3 = new Employe() { FirstName = "Robert", LastName = "Reagan", BirthDate = new DateTime(1955, 8, 12), Title = "Mr", Position = "CEO" }; ;
                Employe employe4 = new Employe() { FirstName = "Cynthia", LastName = "Heart", BirthDate = new DateTime(1970, 9, 21), Title = "Mrs", Position = "CEO" };
                Employe employe5 = new Employe() { FirstName = "John", LastName = "Mayem", BirthDate = new DateTime(1975, 12, 12), Title = "Mr", Position = "CEO" };
                Employe employe6 = new Employe() { FirstName = "Monti", LastName = "Browski", BirthDate = new DateTime(1984, 5, 29), Title = "Mr", Position = "CEO" };
                Employe employe7 = new Employe() { FirstName = "Alex", LastName = "Guerro", BirthDate = new DateTime(1979, 1, 1), Title = "Mr", Position = "CEO" };
                Employe employe8 = new Employe() { FirstName = "Phill", LastName = "Brooks", BirthDate = new DateTime(1974, 12, 14), Title = "Mr", Position = "CEO" };
                Employe employe9 = new Employe() { FirstName = "Maison", LastName = "Palermo", BirthDate = new DateTime(1974, 12, 13), Title = "Mr", Position = "CEO" };
                Employe employe10 = new Employe() { FirstName = "William", LastName = "Regal", BirthDate = new DateTime(1974, 12, 17), Title = "Mr", Position = "CEO" };
                Employe employe11= new Employe() { FirstName = "Mike", LastName = "Grahman", BirthDate = new DateTime(1974, 12, 20), Title = "Mr", Position = "CEO" };
                Employe employe12 = new Employe() { FirstName = "Miroslav", LastName = "Mierro", BirthDate = new DateTime(1974, 12, 25), Title = "Mr", Position = "CEO" };
                History history = new History() { OrderDate=new DateTime(2013,11,12), StoreCity="Las Vegas"};
                History history2 = new History() { OrderDate = new DateTime(2013, 11, 14), StoreCity = "Las Vegas" };
                History history3 = new History() { OrderDate = new DateTime(2013, 11, 18), StoreCity = "San Jose" };
                History history4 = new History() { OrderDate = new DateTime(2013, 11, 22), StoreCity = "Las Denver" };
                History history5 = new History() { OrderDate = new DateTime(2013, 11, 30), StoreCity = "Seattle" };
                History history6 = new History() { OrderDate = new DateTime(2013, 12, 1), StoreCity = "San Jose" };
                History history7 = new History() { OrderDate = new DateTime(2013, 11, 12), StoreCity = "Minnisota" };
                History history8 = new History() { OrderDate = new DateTime(2013, 11, 14), StoreCity = "Detroit" };
                History history9 = new History() { OrderDate = new DateTime(2013, 11, 18), StoreCity = "New-York" };
                History history10 = new History() { OrderDate = new DateTime(2013, 11, 22), StoreCity = "San Diego" };
                History history11 = new History() { OrderDate = new DateTime(2013, 11, 30), StoreCity = "Miami" };
                History history12 = new History() { OrderDate = new DateTime(2013, 12, 1), StoreCity = "Denver" };
                Note note = new Note() { InvoiceNumber = "35703", Employe = employe };
                Note note2 = new Note() { InvoiceNumber = "35704", Employe = employe2 };
                Note note3 = new Note() { InvoiceNumber = "35705", Employe = employe3 };
                Note note4 = new Note() { InvoiceNumber = "35706", Employe = employe4 };
                Note note5 = new Note() { InvoiceNumber = "35707", Employe = employe5 };
                Note note6 = new Note() { InvoiceNumber = "35708", Employe = employe6 };
                Note note7 = new Note() { InvoiceNumber = "35709", Employe = employe7 };
                Note note8 = new Note() { InvoiceNumber = "357010", Employe = employe8 };
                Note note9 = new Note() { InvoiceNumber = "357011", Employe = employe9 };
                Note note10 = new Note() { InvoiceNumber = "357012", Employe = employe10 };
                Note note11 = new Note() { InvoiceNumber = "35713", Employe = employe11 };
                Note note12 = new Note() { InvoiceNumber = "35700", Employe = employe12 };
                Company company = new Company() { Name = "Super Mart of the West", City = "Bentonville", State = "Arkansas", Phone = "(800) 555-2787", Address = "702 SW 8th Street", Employees = new List<Employe>() { employe, employe2 }, Histories = new List<History>() {history, history2, history3 }, Notes=new List<Note>() { note,note2 } };
                Company company2 = new Company() { Name = "Electronics Depot", City = "aTLANTA", State = "Georgia", Phone = "(800) 595-3232", Address = "701 MW 1th Street", Employees = new List<Employe>() { employe3, employe4}, Histories = new List<History>() { history4, history5 }, Notes = new List<Note>() { note3, note4 } };
                Company company3 = new Company() { Name = "K&S Music", City = "Minneapolis", State = "Minnesota", Phone = "(612)304-2231", Address = "606 DV 5th Street", Employees = new List<Employe>() { employe5, employe6 }, Histories = new List<History>() { history6,history7 }, Notes = new List<Note>() { note5, note6 } };
                Company company4 = new Company() { Name = "Tom's Club", City = "Issaquah", State = "Washington", Phone = "(800) 955-2292", Address = "153 MM 13th Street", Employees = new List<Employe>() { employe7, employe8 }, Histories = new List<History>() { history8, history9 }, Notes = new List<Note>() { note7, note8 } };
                Company company5 = new Company() { Name = "Walters", City = "Deerfield", State = "Illinois", Phone = "(847) 940-2500", Address = "502 VM 8th Street", Employees = new List<Employe>() { employe9, employe10 }, Histories = new List<History>() { history10, history11 }, Notes = new List<Note>() { note9, note10 } };
                Company company6 = new Company() { Name = "StereoShack", City = "Forth Worth", State = "Texas", Phone = "(817) 820-0741", Address = "375 WW 5th Street", Employees = new List<Employe>() { employe11, employe12 }, Histories = new List<History>() { history12 }, Notes = new List<Note>() { note11, note12 } };
                Employees.AddRange(employe, employe2, employe3, employe4, employe5, employe6, employe7, employe8, employe9, employe10, employe11, employe12);
                Histories.AddRange(history, history2, history3, history4, history5, history6, history7, history8, history9, history10, history11, history12);
                Notes.AddRange(note, note2, note3, note4, note5, note6, note7, note8, note9, note10, note11, note12);
                Companies.AddRange(company, company2, company3, company4, company5, company6);
                SaveChanges();

            }

        }


        public List<Company> GetCompanies() => Companies.ToList();

        public Company GetCompanyById(int id) => Companies.Include(v=>v.Histories).Include(v=>v.Employees).Include(v=>v.Notes).FirstOrDefault(v=>v.Id==id);
    }
}
