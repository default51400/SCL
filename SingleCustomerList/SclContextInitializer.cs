using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCustomerList
{
    public class SclContextInitializer : CreateDatabaseIfNotExists<SclContext>//DropCreateDatabaseAlways|||||DropCreateDatabaseIfModelChanges|||||CreateDatabaseIfNotExists
    {
        protected override void Seed(SclContext context)
        {
            context.Regions.AddOrUpdate(x => x.Name, FillDefaultRegions().ToArray());
            context.SaveChanges();
            context.Categories.AddOrUpdate(x => x.Name, FillDefaultCategories().ToArray());
            context.SaveChanges();
            context.Cities.AddOrUpdate(x => x.Name, FillDefaultCities(context).ToArray());
            context.SaveChanges();
            //context.Regions.AddRange(FillDefaultRegions().ToArray());
            //context.Categories.AddRange(FillDefaultCategories().ToArray());
            //context.Cities.AddRange(FillDefaultCities(context).ToArray());
            //Debug.WriteLine("Seed finished");
            InitializationDefaultValuesOrganizationsAndCustomers(context);
        }

        private static void InitializationDefaultValuesOrganizationsAndCustomers(SclContext context)
        {
            Organization org1 = new Organization();
            //org.OrganizationId
            org1.OrgName = "Апостолівська державна нотаріальна контора";
            org1.OrgShortName = "Апостолівська ДНК";
            org1.OrgStatus = "Діє";
            org1.OrgCategory = "Державна нотаріальна контора";
            org1.OrgCodeRc = "ДН20955";
            org1.OrgRegion = "Дніпропетровська обл.";
            org1.OrgAdress = "53802 Дніпропетровська обл., Апостолівський р., м. Апостолове, вул. Центральна, 66";
            org1.OrgPhone = "(056) 569-1889;               (   )    -    ;";
            org1.OrgEDRPOY = "25384501";
            org1.OrgDetail = "АОРС №123123";
            context.Organizations.Add(org1);

            Organization org2 = new Organization();
            //org2.OrganizationId
            org2.OrgName = "Відділ державної реєстрації актів цивільного стану Управління державної реєстрації Головного територіального управління юстиції у Дніпропетровській області";
            org2.OrgShortName = "ВДРАЦС ГТУЮ";
            org2.OrgStatus = "Діє";
            org2.OrgCategory = "Відділи ДРАЦС";
            org2.OrgCodeRc = "ДН52104";
            org2.OrgRegion = "Дніпропетровська обл.";
            org2.OrgAdress = "49006 Дніпропетровська обл., м. Дніпропетровськ, вул. Шмідта, 43-а";
            org2.OrgPhone = "(056) 371-2748;               (   )    -    ;";
            org2.OrgEDRPOY = "34984907";
            org2.OrgDetail = "аорс 358698; аорс 1361";
            context.Organizations.Add(org2);

            Organization org3 = new Organization();
            //org3.OrganizationId
            org3.OrgName = "Донецька народна республіка";
            org3.OrgShortName = "ДНР";
            org3.OrgStatus = "Діє";
            org3.OrgCategory = "Органи державної влади(Державні служби, комітети, РДА)";
            org3.OrgCodeRc = "ДО3223245";
            org3.OrgRegion = "Донецька обл.";
            org3.OrgAdress = "Донецкь, вул..фівфів";
            org3.OrgPhone = "(312) 312-3111;               (   )    -    ;";
            org3.OrgEDRPOY = "31231231";
            org3.OrgDetail = "АОРС 21312312";
            context.Organizations.Add(org3);

            Login login1 = new Login();
            Customer cust1 = new Customer();
            cust1.SurName = "Штельмак";
            cust1.FirstName = "Наталія";
            cust1.LastName = "Афанасіївна";
            cust1.UserStatus = "Діє";
            cust1.UserIdINN = "2218719147";
            cust1.WorkingPosition = "державний нотаріус";
            cust1.Phone = "(   )    -    ;               (   )    -    ;";
            cust1.Detail = "AOPC 2131231";
            cust1.OrganizationName = "Апостолівська ДНК";
            //cust1.Orgname.OrganizationId = 1;
            Category category1 = context.Categories.FirstOrDefault(x => x.Name.Equals("Державна нотаріальна контора"));
            login1.Category = category1;
            Region region1 = context.Regions.FirstOrDefault(x => x.Name.Equals("Дніпропетровська обл."));
            login1.Region = region1;
            City city1 = context.Cities.FirstOrDefault(x => x.Name.Equals("Апостолове"));
            login1.City = city1;
            login1.Number = "0001";
            login1.IsActive = true;
            login1.Customer = cust1;
            login1.BuildLogin();
            context.Logins.Add(login1);
            context.Customers.Add(cust1);

            Login login2 = new Login();
            Customer cust2 = new Customer();
            cust2.SurName = "Астанiна";
            cust2.FirstName = "Iрина";
            cust2.LastName = "Леонiдiвна";
            cust2.UserStatus = "Діє";
            cust2.UserIdINN = "2323245622";
            cust2.WorkingPosition = "провiдний спеціалiст";
            cust2.Phone = "(123)1233-1231;               (   )    -    ;";
            cust2.Detail = "AOPC 123511";
            cust2.OrganizationName = "ВДРАЦС ГТУЮ";
            //cust2.Orgname.OrganizationId = 1;
            Category category2 = context.Categories.FirstOrDefault(x => x.Name.Equals("Відділи ДРАЦС"));
            login2.Category = category2;
            Region region2 = context.Regions.FirstOrDefault(x => x.Name.Equals("Дніпропетровська обл."));
            login2.Region = region2;
            City city2 = context.Cities.FirstOrDefault(x => x.Name.Equals("Дніпро (Дніпропетровськ)"));
            login2.City = city2;
            login2.Number = "0001";
            login2.IsActive = true;
            login2.Customer = cust2;
            login2.BuildLogin();
            context.Logins.Add(login2);
            context.Customers.Add(cust2);

            Login login3 = new Login();
            Customer cust3 = new Customer();
            cust3.SurName = "Аврамов";
            cust3.FirstName = "Дмитро";
            cust3.LastName = "Артемович";
            cust3.UserStatus = "Діє";
            cust3.UserIdINN = "9562614482";
            cust3.WorkingPosition = "провiдний спеціалiст";
            cust3.Phone = "(312)3217-8614;               (   )    -    ;";
            cust3.Detail = "AOPC 523344";
            cust3.OrganizationName = "ДНР";
            //cust3.Orgname.OrganizationId = 1;
            Category category3 = context.Categories.FirstOrDefault(x => x.Name.Equals("Органи державної влади(Державні служби, комітети, РДА)"));
            login3.Category = category3;
            Region region3 = context.Regions.FirstOrDefault(x => x.Name.Equals("Донецька обл."));
            login3.Region = region3;
            City city3 = context.Cities.FirstOrDefault(x => x.Name.Equals("Донецьк"));
            login3.City = city3;
            login3.Number = "0001";
            login3.IsActive = true;
            login3.Customer = cust3;
            login3.BuildLogin();
            context.Logins.Add(login3);
            context.Customers.Add(cust3);

            context.SaveChanges();
        }

        private IEnumerable<Region> FillDefaultRegions()
        {
            return new List<Region>
            {
                new Region
                {
                    Name = "Дніпропетровська обл.",
                    LoginRegion = "dn"

                },
                new Region
                {
                    Name = "Донецька обл.",
                    LoginRegion = "do"
                }
            };
        }

        private IEnumerable<City> FillDefaultCities(SclContext context)
        {
            Region dneprRegion = context.Regions.FirstOrDefault(x => x.LoginRegion.Equals("dn"));
            Region donetskRegion = context.Regions.FirstOrDefault(x => x.LoginRegion.Equals("do"));

            return new List<City>
            {
                new City
                {
                    Name = "Дніпро (Дніпропетровськ)",
                    LoginCode = "00",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Кам'янське (Днепродзержинск)",
                    LoginCode = "01",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Кривий Ріг",
                    LoginCode = "02",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Слобожанське (сел.Ювілейне)",
                    LoginCode = "03",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Нікополь",
                    LoginCode = "05",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Павлоград",
                    LoginCode = "06",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Новомоськ місто",
                    LoginCode = "07",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Солоне",
                    LoginCode = "08",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Синельниково",
                    LoginCode = "09",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Верхньодніпровськ",
                    LoginCode = "10",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "П'ятихатки",
                    LoginCode = "11",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Новомоськ район",
                    LoginCode = "12",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Петриківка",
                    LoginCode = "13",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Магдалинівка",
                    LoginCode = "14",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Васильківка",
                    LoginCode = "15",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Софіївка",
                    LoginCode = "16",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Жовті Води",
                    LoginCode = "17",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Апостолове",
                    LoginCode = "18",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Широке",
                    LoginCode = "19",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Петропавлівка",
                    LoginCode = "20",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Першотравенськ",
                    LoginCode = "21",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Вільногірськ",
                    LoginCode = "22",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Тернівка",
                    LoginCode = "23",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Юр'ївка",
                    LoginCode = "24",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Межова",
                    LoginCode = "25",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Покровське",
                    LoginCode = "26",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Кринички",
                    LoginCode = "27",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Царичанка",
                    LoginCode = "28",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Синельниково район",
                    LoginCode = "29",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Марганець",
                    LoginCode = "30",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Томаківка",
                    LoginCode = "31",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Покров (Орджонікідзе)",
                    LoginCode = "32",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Зеленодольськ",
                    LoginCode = "33",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Дослідне",
                    LoginCode = "34",
                    Region = dneprRegion
                },
                new City
                {
                    Name = "Щорськ",
                    LoginCode = "35",
                    Region = dneprRegion
                },

                //Donetsk region
                new City
                {
                    Name = "Донецьк",
                    LoginCode = "00",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Макіївка",
                    LoginCode = "01",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Маріуполь",
                    LoginCode = "02",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Покровськ(Красноармейск)",
                    LoginCode = "03",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Горлівка",
                    LoginCode = "04",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Старобешеве",
                    LoginCode = "05",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Слов'янськ",
                    LoginCode = "06",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Краматорськ",
                    LoginCode = "07",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Авдіївка",
                    LoginCode = "08",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Амвросіївка",
                    LoginCode = "09",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Бахмут(Артемівськ)",
                    LoginCode = "10",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Велика Новосілка",
                    LoginCode = "11",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Волноваха",
                    LoginCode = "12",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Нікольське(Володарське)",
                    LoginCode = "13",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Вугледар",
                    LoginCode = "14",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Дебальцеве",
                    LoginCode = "15",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Торецьк(Дзержинськ)",
                    LoginCode = "16",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Мирноград(Димитрово)",
                    LoginCode = "17",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Добропілля",
                    LoginCode = "18",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Докучаєвськ",
                    LoginCode = "19",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Дружківка",
                    LoginCode = "20",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Єнакієве",
                    LoginCode = "21",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Жданівка",
                    LoginCode = "22",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Зугрес",
                    LoginCode = "23",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Хрестівка(Кировське)",
                    LoginCode = "24",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Костянтинівка",
                    LoginCode = "25",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Красногорівка",
                    LoginCode = "26",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Лиман(Красний Лиман)",
                    LoginCode = "27",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Курахове",
                    LoginCode = "28",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Мар'їнка",
                    LoginCode = "29",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Новоазовськ",
                    LoginCode = "30",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Новогродівка",
                    LoginCode = "31",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Олександрівка",
                    LoginCode = "32",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Мангушський район(Першотравневий)",
                    LoginCode = "33",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Селидове",
                    LoginCode = "34",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Сніжне",
                    LoginCode = "35",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Соледар",
                    LoginCode = "36",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Бойківське(Тельманове)",
                    LoginCode = "37",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Чистякове(Торез)",
                    LoginCode = "38",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Харцизьк",
                    LoginCode = "39",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Часів Яр",
                    LoginCode = "40",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Шахтарськ",
                    LoginCode = "41",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Ясинувата",
                    LoginCode = "42",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Мангуш",
                    LoginCode = "43",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Гірник",
                    LoginCode = "44",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Оленівка",
                    LoginCode = "50",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Миколаївка",
                    LoginCode = "51",
                    Region = donetskRegion
                },
                new City
                {
                    Name = "Світлодарськ",
                    LoginCode = "52",
                    Region = donetskRegion
                }

            };
        }

        private IEnumerable<Category> FillDefaultCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Адвокати",
                    LoginCategory = "ad"
                },
                new Category
                {
                    Name = "Банківська установа",
                    LoginCategory = "b"
                },
                new Category
                {
                    Name = "Виконавчі органи с./сщ./міськ. рад",
                    LoginCategory = "vk"
                },
                new Category
                {
                    Name = "Відділ ДВС - виконавець",
                    LoginCategory = "v"
                },
                new Category
                {
                    Name = "Відділ ДВС - реєстр рішень",
                    LoginCategory = "rsd"
                },
                new Category
                {
                    Name = "Відділення бюро технічної інвентаризації",
                    LoginCategory = "dr"
                },
                new Category
                {
                    Name = "Відділи ДРАЦС",
                    LoginCategory = "r"
                },
                new Category
                {
                    Name = "Державна нотаріальна контора",
                    LoginCategory = "d"
                },
                new Category
                {
                    Name = "Державна податкова служба",
                    LoginCategory = "dps"
                },
                new Category
                {
                    Name = "ДП НАІС",
                    LoginCategory = "n"
                },
                new Category
                {
                    Name = "Інші організації",
                    LoginCategory = "in"
                },
                new Category
                {
                    Name = "Кредитні спілки, ВАТ тощо",
                    LoginCategory = "in"
                },
                new Category
                {
                    Name = "Нацполіція, УМВС",
                    LoginCategory = "ovs"
                },
                new Category
                {
                    Name = "Органи державної влади(Державні служби, комітети, РДА)",
                    LoginCategory = "odv"
                },
                new Category
                {
                    Name = "Органи місцевого самоврядування",
                    LoginCategory = "oms"
                },
                new Category
                {
                    Name = "Органи юстиції(доступ ЄРД, РНБ)",
                    LoginCategory = "u"
                },
                new Category
                {
                    Name = "Органи юстиції(доступ РГФ, ДЗМІ)",
                    LoginCategory = "g"
                },
                new Category
                {
                    Name = "Приватна нотаріальна контора",
                    LoginCategory = "p" //dn00p3211
                },
                new Category
                {
                    Name = "Приватна нотаріальна контора - помічник",
                    LoginCategory = "p"//dn00p3211s1
                },
                new Category
                {
                    Name = "Приватна виконавча контора",
                    LoginCategory = "pv" //dn00pv3211
                },
                new Category
                {
                    Name = "Приватна виконавча контора - помічник",
                    LoginCategory = "pv"//dn00pv3211s1
                },
                new Category
                {
                    Name = "Прокуратура",
                    LoginCategory = "pr"
                },
                new Category
                {
                    Name = "Регіональний сервісний центр МВС",
                    LoginCategory = "dai"
                },
                new Category
                {
                    Name = "СБУ",
                    LoginCategory = "sbu"
                },
                new Category
                {
                    Name = "СУДИ",
                    LoginCategory = "sud"
                },
                new Category
                {
                    Name = "ЦНАП",
                    LoginCategory = "cnp"
                },
                new Category
                {
                    Name = "ЦНАП - державний реєстратор",
                    LoginCategory = "dr"
                }
            };
        }
    }
}
