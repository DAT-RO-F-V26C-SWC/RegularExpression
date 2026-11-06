using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionLib.Validation
{
    public static class MyValidator
    {
        private const String CheckNamePattern = @"^[a-zA-ZæøåÆØÅ][a-zA-ZæøåÆØÅ\s\.-]*$"; //start and ends with letters minimum 1 letter
        public static bool CheckName(String name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            Regex regex = new Regex(CheckNamePattern);
            return regex.IsMatch(name);
        }

        private const String CheckZipPattern = @"^\d{4}$"; //start and ends with exact 4 digits
        public static bool CheckZip(String zip)
        {
            if (string.IsNullOrEmpty(zip))
                return false;

            Regex regex = new Regex(CheckZipPattern);
            return regex.IsMatch(zip); // alt: regex.IsMatch(zip.ToString());
        }

        private const String CheckHouseNumberPattern = @"^\d+\s*\w?\s*\d*\s*\.?(tv|th|m)?$"; //start and ends with ex 167 B 1tv
        public static bool CheckHouseNumber(String number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            Regex regex = new Regex(CheckHouseNumberPattern);
            return regex.IsMatch(number);
        }

        private const String CheckPhonePattern = @"^(\+\d{2}\s*)?\d{8}$"; //start and ends with exact 8 digits possible prefixed with +xx
        public static bool CheckPhone(String phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            Regex regex = new Regex(CheckPhonePattern);
            return regex.IsMatch(phone);
        }

        private const String CheckEmailPattern = @"^\w[\w\.\-_]*@(\w+\.)+\w{1,5}$"; //start and ends with email aka ksdjfkjf.sdfklk-3@gafkd.com
        public static bool CheckEmail(String mail)
        {
            if (string.IsNullOrEmpty(mail))
                return false;

            Regex regex = new Regex(CheckEmailPattern);
            return regex.IsMatch(mail);
        }

    }
}
