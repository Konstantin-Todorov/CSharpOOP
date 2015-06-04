namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Engine.Factories;
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company : CompanyFactory ,ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.furnitures = new List<IFurniture>();
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get { return this.name; }
            protected set //Name cannot be empty, null or with less than 5 symbols.
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be with less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            protected set //Registration number must be exactly 10 symbols and must contain only digits. 
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits.");
                }

                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contain only digits.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("{0} - {1} - {2} {3}",
                        this.Name,
                        this.RegistrationNumber,
                        this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                        this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                                ));
            foreach (var furniture in this.furnitures.OrderBy(f=>f.Price)
                                                     .ThenBy(f=>f.Model))
            {
                stringBuilder.AppendLine(furniture.ToString()); 
            }
            //stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString().TrimEnd();
        }

        private bool ContainsOnlyDigits(string str)
        {
            foreach (var ch in str)
            {
                //if (ch < '0' || ch> '9')
                if(!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
