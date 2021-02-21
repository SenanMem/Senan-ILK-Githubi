using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

            //var debtors1 = DebtorList.GetDebtors().FindAll(s => s.Email.Contains("rhyta.com") || s.Email.Contains("dayrep.com"));
            //debtors1.ForEach(s => Console.WriteLine(s.Email));

            ////2) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag

            //var debtors2 = DebtorList.GetDebtors().FindAll(s => DateTime.Now.Year - s.BirthDay.Year >= 26 && (DateTime.Now.Year - s.BirthDay.Year) <= 36);
            //debtors2.ForEach(s => Console.WriteLine(s.BirthDay.ToShortDateString()));

            ////3) Borcu 5000 - den cox olmayan borclularic cixartmag

            //var debtors3 = DebtorList.GetDebtors().FindAll(s => s.Debt < 5000);
            //debtors3.ForEach(s => Console.WriteLine(s.Debt));

            ////4) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq

            //var debtors4 = DebtorList.GetDebtors().FindAll(s => s.FullName.Length >= 18 && s.Phone.Count(c=> c =='7') >= 2);
            //debtors4.ForEach(s => Console.WriteLine($"{s.FullName}  {s.Phone}"));

            ////5) Qishda anadan olan borclulari cixardmaq

            //var debtors5 = DebtorList.GetDebtors().FindAll(s => s.BirthDay.Month == 12 || s.BirthDay.Month == 1 || s.BirthDay.Month == 2);
            //debtors5.ForEach(s => Console.WriteLine(s.BirthDay.ToShortDateString()));

            ////6) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
            //var AvgDebt = DebtorList.GetDebtors().Average(s => s.Debt);
            //var HigherThanAvg = DebtorList.GetDebtors().FindAll(s => s.Debt > AvgDebt);
            //var DebtorSortBySurname = HigherThanAvg.OrderBy(s => s.FullName).ToList();
            //DebtorSortBySurname.ForEach(d => Console.WriteLine($"{d.FullName}  {d.Debt} "));
            //var DebtorsSortByDebpt = DebtorSortBySurname.OrderByDescending(d => d.Debt).ToList();
            //DebtorsSortByDebpt.ForEach(d => Console.WriteLine($"{d.FullName}  {d.Debt} "));
            ////7) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq

            //  var debtors7 = DebtorList.GetDebtors().FindAll(s => !s.Phone.Contains('8'));
            //  debtors7.ForEach(s => Console.WriteLine($"{s.FullName}  {s.BirthDay.ToShortDateString()} {s.Debt}"));

            ////8)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek

            //var debtors8 = DebtorList.GetDebtors().FindAll(s => s.FullName.CheckOccurrence(3) == true).OrderBy(d => d.FullName).ToList();
            //debtors8.ForEach(s => Console.WriteLine($"{s.FullName}"));


            ////9)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

            //var debtors9 = DebtorList.GetDebtors().OrderBy(s => s.BirthDay.Year).ToList();
            //Console.WriteLine(debtors9[0].BirthDay.ToShortDateString());

            ////10)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

            //var debtors10 = DebtorList.GetDebtors().OrderByDescending(s => s.Debt).Take(5).ToList();
            //debtors10.ForEach(d => Console.WriteLine(d.Debt));

            ////11)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
            //var SumDebt = DebtorList.GetDebtors().Sum(d => d.Debt);
            //Console.WriteLine(SumDebt);

            ////12)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
            //var debtors12 = DebtorList.GetDebtors().FindAll(s => s.BirthDay.Year <= 1945);
            //debtors12.ForEach(s => Console.WriteLine(s.BirthDay.ToShortDateString()));

            ////13)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq
            //var debtors13 = DebtorList.GetDebtors().FindAll(d =>
            //{
            //    foreach (var numbers in "0123456789")
            //    {
            //        if (d.Phone.Count(c=>c ==numbers)>1)
            //            return false;
            //    }
            //    return true;
            //});
            //debtors13.ForEach(s => Console.WriteLine(s.Phone));

            ////14)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq
            //bool control = true;
            //var debtors14 = DebtorList.GetDebtors().FindAll(d =>
            //{
            //    if (d.Debt < 6000)
            //    {
            //        if (d.BirthDay.Month == DateTime.Now.Month)
            //        {
            //            if (d.BirthDay.Day < DateTime.Now.Day)
            //            {
            //                if (d.Debt - 500 * 12 <= 0) control = true;
            //                else control = false;
            //            }
            //            else control = false;
            //        }
            //        else if (d.BirthDay.Month > DateTime.Now.Month)
            //        {
            //            if (d.Debt - (d.BirthDay.Month - DateTime.Now.Month) * 500 <= 0)
            //            {
            //                control = true;
            //            }
            //            else control = false;
            //        }
            //        else if (d.BirthDay.Month < DateTime.Now.Month)
            //        {
            //            if (d.Debt - ((d.BirthDay.Month + 12 - DateTime.Now.Month) * 500) <= 0)
            //            {
            //                control = true;
            //            }
            //            else control = false;
            //        }
            //        else control = false;
            //    }
            //    else control = false;
            //    return control;
            //});
            //debtors14.ForEach(s => Console.WriteLine($"{s.BirthDay.ToShortDateString()}    {s.Debt}"));
            ////15)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
            //var debtors1 = DebtorList.GetDebtors().FindAll(s => s.FullName.ToLower().Contains("s") && s.FullName.ToLower().Contains("m")
            //&& s.FullName.ToLower().Contains("i") && s.FullName.ToLower().Contains("l") && s.FullName.ToLower().Contains("e"));
            //debtors1.ForEach(s => Console.WriteLine(s.FullName));
        }
    }
}
