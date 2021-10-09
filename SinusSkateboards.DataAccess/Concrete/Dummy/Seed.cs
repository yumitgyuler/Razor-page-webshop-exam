using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.Dummy
{
    public static class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            await GenerateBillingAdress(context);
            await GenerateShippingAdress(context);
            await GenerateUser(context);
            await GenerateAttributeType(context);
            await GenerateProductAttribute(context);
            await GenerateCategory(context);
            await GenerateProductGroup(context);
            await GenerateImage(context);
            await GenerateOrderStatus(context);
            await GenerateProduct(context);
            await GenerateOrder(context);
        }
        public static async Task GenerateBillingAdress(DataContext context)
        {
            if (context.BillingAdresses.Any()) return;

            var data = new List<BillingAdress>
            {
                new BillingAdress{
                    Id = Guid.Parse("867B3BEC-CB93-65DB-8D21-6F12249A515A"),
                    FirstName = "Quinlan",
                    LastName = "Tate",
                    Street = "6555 Nam St.",
                    City = "Motala",
                    Zip = "73525",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("15C1C447-7B4D-829C-6DE6-193CA57A8CBA"),
                    FirstName="Leroy",
                    LastName ="Larson",
                    Street = "191-4383 Tempor, Ave",
                    City = "Bollnäs",
                    Zip = "68975",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("743CEA1D-3C83-D25A-3FC4-38C5E824FECB"),
                    FirstName = "Zahir",
                    LastName = "Strickland",
                    Street = "7212 Blandit Ave",
                    City = "Nässjö",
                    Zip = "85858",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("BC3CD434-46EA-98F1-EE16-96E6A26C665E"),
                    FirstName = "Macaulay",
                    LastName = "Mcmahon",
                    CompanyName = "Dolor Elit Ltd",
                    Street = "P.O. Box 187, 6171 Scelerisque Avenue",
                    City = "Göteborg",
                    Zip = "24558",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("0C2BD9F1-2BC2-D436-BB85-2BD3D98D835D"),
                    FirstName = "Vernon",
                    LastName = "Spencer",
                    CompanyName = "Etiam Incorporated",
                    Street = "Ap #673-7889 Tellus. St.",
                    City = "Mjölby",
                    Zip = "14556",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("84E04022-BD69-37A4-7021-432624948D39"),
                    FirstName = "Wayne",
                    LastName = "Mccray",
                    CompanyName = "Aliquam Eu Foundation",
                    Street = "P.O. Box 157, 3015 Tincidunt, St.",
                    City = "Nässjö",
                    Zip = "38157",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("319EBE58-DBED-2AC9-27B3-E5E2AD8681B1"),
                    FirstName = "Fleur",
                    LastName = "Mcdaniel",
                    CompanyName = "Eget Ltd",
                    Street = "Ap #462-1445 Pharetra Ave",
                    City = "Motala",
                    Zip = "34102",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("5245D3AA-49D0-D622-CE6A-5374EE9712CA"),
                    FirstName = "Buckminster",
                    LastName = "Mason",
                    CompanyName = "Nunc Institute",
                    Street = "805-5332 Ac Rd.",
                    City = "Hudiksvall",
                    Zip = "01818",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("D2BB6A49-5E88-70E4-8E43-024BE14BA393"),
                    FirstName = "Barclay",
                    LastName = "Morrow",
                    Street = "756-9445 Ante St.",
                    City = "Hudiksvall",
                    Zip = "54584",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("A5AEA169-2978-D12D-0E88-CEB342B7EEB5"),
                    FirstName = "Nolan",
                    LastName = "Butler",
                    Street = "P.O. Box 618, 4914 Arcu. Avenue",
                    City = "Trollhättan",
                    Zip = "32264",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("06520813-F31C-2184-F147-7FB2775762DB"),
                    FirstName = "Peter",
                    LastName = "Vance",
                    Street = "772-4570 Ipsum Av.",
                    City = "Nässjö",
                    Zip = "09255",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("8A92DF59-E3A7-4452-ABDD-D93A32EC59D8"),
                    FirstName = "Bradley",
                    LastName = "Barron",
                    Street = "Ap #527-8013 Integer Street",
                    City = "Motala",
                    Zip = "28781",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("41250536-4C1E-874B-7A7C-DE25B8A53A1C"),
                    FirstName = "Mariam",
                    LastName = "Reid",
                    CompanyName = "Ut LLP",
                    Street = "Ap #867-5735 Ornare. Av.",
                    City = "Tumba",
                    Zip = "46318",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("02FAC50C-519B-0619-6EED-C15F9366A811"),
                    FirstName = "Beatrice",
                    LastName = "Boyer",
                    Street = "6255 Mi Avenue",
                    City = "Finspång",
                    Zip = "87564",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("14F42C04-CC97-8EBA-8540-477C92AD23F5"),
                    FirstName = "Kelly",
                    LastName = "Weiss",
                    Street = "Ap #872-8216 Duis Ave",
                    City = "Borås",
                    Zip = "75528",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("5AAC2DFC-AD1A-AA4E-01C9-B668824C5755"),
                    FirstName = "Alana",
                    LastName = "Matthews",
                    Street = "865-1319 Et, Street",
                    City = "Hofors",
                    Zip = "20553",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("4C494DB9-2072-B27E-4B55-672AAE5E6834"),
                    FirstName = "Orlando",
                    LastName = "Goodman",
                    Street = "547-6412 Justo Street",
                    City = "Tranås",
                    Zip = "76973",
                    Country ="Sweden",
                    ShipToOtherAdress = true
                },
                new BillingAdress{
                    Id = Guid.Parse("28AA8BDC-126F-159C-74CD-03BB468B615D"),
                    FirstName = "Barrett",
                    LastName ="Fox",
                    CompanyName = "Phasellus LLP",
                    Street = "Ap #579-6432 Non Rd.",
                    City = "Gävle",
                    Zip = "82444",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("46BE6F28-4190-892E-9650-9584CC92EEE7"),
                    FirstName = "Florence",
                    LastName = "Vargas",
                    CompanyName = "Sollicitudin Institute",
                    Street = "Ap #259-5831 Convallis St.",
                    City = "Ludvika",
                    Zip = "42641",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                },
                new BillingAdress{
                    Id = Guid.Parse("FD632EC7-08A4-5B56-32DE-EB4E865237C9"),
                    FirstName = "Tobias",
                    LastName = "Salinas",
                    CompanyName = "Quis Diam Institute",
                    Street = "9063 Quam Rd.",
                    City = "Vetlanda",
                    Zip = "13427",
                    Country ="Sweden",
                    ShipToOtherAdress = false
                }
            };
            await context.BillingAdresses.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateShippingAdress(DataContext context)
        {
            if (context.ShippingAdresses.Any()) return;

            var data = new List<ShippingAdress>
            {
                new ShippingAdress{
                    Id = Guid.Parse("2518256E-330B-57B4-C612-57D7BB7E37B2"),
                    FirstName = "Macaulay",
                    LastName = "Mcmahon",
                    Street = "Ap #457-8494 Fringilla Av.",
                    City = "Norrköping",
                    Zip = "65280",
                    Country ="Sweden"
                },
                new ShippingAdress{
                    Id = Guid.Parse("B4C755B5-F4BC-EE4D-0A7C-16CB917CE424"),
                    FirstName = "Leroy",
                    LastName = "Larson",
                    Street = "Ap #130-9172 Magnis Street",
                    City = "Mjölby",
                    Zip = "10847",
                    Country ="Sweden"
                },
                new ShippingAdress{
                    Id = Guid.Parse("13C4B337-5772-2168-4B11-1BF148C1ABCE"),
                    FirstName = "Orlando",
                    LastName = "Goodman",
                    Street = "P.O. Box 700, 494 Conubia Ave",
                    City = "Lerum",
                    Zip = "27925",
                    Country ="Sweden"
                },
                new ShippingAdress{
                    Id = Guid.Parse("32158CB4-CDC9-93FF-CECE-35DCA5602DFA"),
                    FirstName = "Quinlan",
                    LastName = "Tate",
                    Street = "Ap #938-1375 Vulputate, Rd.",
                    City = "Lidingo",
                    Zip = "98669",
                    Country ="Sweden"
                },
                new ShippingAdress{
                    Id = Guid.Parse("2C288B88-A3B2-1594-D8DA-DA934269563E"),
                    FirstName = "Fleur",
                    LastName = "Mcdaniel",
                    Street = "P.O. Box 147, 8970 Phasellus Avenue",
                    City = "Upplands Väsby",
                    Zip = "25435",
                    Country ="Sweden"
                },
                new ShippingAdress{
                    Id = Guid.Parse("8D69EC5A-8E69-4C9F-30B9-B1D4963F6CD3"),
                    FirstName = "Bradley",
                    LastName = "Barron",
                    Street = "P.O. Box 150, 3085 Non, Rd.",
                    City = "Lidköping",
                    Zip = "15252",
                    Country ="Sweden"
                }
            };
            await context.ShippingAdresses.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateUser(DataContext context)
        {
            if (context.Users.Any()) return;

            var data = new List<User>
            {
                new User{
                    Id = "54807BA4-7DE1-5C9E-C43D-B8DD77D7986D",
                    FirstName = "Yumit",
                    LastName = "Gyuler",
                    Email = "info@pscreative.se",
                    UserName = "info@pscreative.se",
                    PasswordHash = "admin",
                    PhoneNumber = "0726549573",
                },new User{
                    Id = "284CA552-9B58-88CB-3696-3C895BF35E91",
                    FirstName = "Barrett",
                    LastName = "Fox",
                    Email = "in.molestie@nec.ca",
                    UserName = "in.molestie@nec.ca",
                    PasswordHash = "PCD12CFG5DJ",
                    PhoneNumber = "0726549573",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("28aa8bdc-126f-159c-74cd-03bb468b615d"))
                },
                new User{
                    Id = "94B98823-44E7-6C92-F4B7-818A7906B658",
                    FirstName = "Leroy",
                    LastName = "Larson",
                    Email = "egestas.urna.justo@magnanec.net",
                    UserName = "egestas.urna.justo@magnanec.net",
                    PasswordHash = "LJW67ATI5IK",
                    PhoneNumber = "0758042790",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("15c1c447-7b4d-829c-6de6-193ca57a8cba")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("b4c755b5-f4bc-ee4d-0a7c-16cb917ce424")),
                },
                new User{
                    Id = "8C861D4D-83B5-76C2-8CC0-1776D4A5ABA2",
                    FirstName = "Vernon",
                    LastName = "Spencer",
                    Email = "orci@etrutrumeu.edu",
                    UserName = "orci@etrutrumeu.edu",
                    PasswordHash = "VAE13OKJ6JZ",
                    PhoneNumber = "0716187222",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("0c2bd9f1-2bc2-d436-bb85-2bd3d98d835d")),
                },
                new User{
                    Id = "9EBC7F1E-C2DE-0A7C-B264-95C110B80748",
                    FirstName = "Zahir",
                    LastName = "Strickland",
                    Email = "et.risus@mauris.org",
                    UserName = "et.risus@mauris.org",
                    PasswordHash = "EHB87HFN0XL",
                    PhoneNumber = "0703251272",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("743cea1d-3c83-d25a-3fc4-38c5e824fecb")),
                },
                new User{
                    Id = "CE002817-C7EB-328B-5056-264D85F2588D",
                    FirstName = "Wayne",
                    LastName = "Mccray",
                    Email = "nunc.sed@vel.net",
                    UserName = "nunc.sed@vel.net",
                    PasswordHash = "EIY19KEW5JN",
                    PhoneNumber = "0705629208",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("84e04022-bd69-37a4-7021-432624948d39")),
                },
                new User{
                    Id = "16C0AD31-EDBC-376A-37C8-F97BF50E989F",
                    FirstName = "Kelly",
                    LastName = "Weiss",
                    Email = "a@tincidunt.co.uk",
                    UserName = "a@tincidunt.co.uk",
                    PasswordHash = "DDG39GBW8YT",
                    PhoneNumber = "0714077379",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("14f42c04-cc97-8eba-8540-477c92ad23f5")),
                },
                new User{
                    Id = "7C5645C5-BAD8-C999-3782-99BFD513873F",
                    FirstName = "Buckminster",
                    LastName = "Mason",
                    Email = "amet.massa@iaculisodionam.co.uk",
                    UserName = "amet.massa@iaculisodionam.co.uk",
                    PasswordHash = "XIP42BUP6CB",
                    PhoneNumber = "0756958561",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("5245d3aa-49d0-d622-ce6a-5374ee9712ca")),
                },
                new User{
                    Id = "1E46D7AE-C9DF-6196-08AE-B36113B7186C",
                    FirstName = "Orlando",
                    LastName = "Goodman",
                    Email = "vivamus@necmollis.net",
                    UserName = "vivamus@necmollis.net",
                    PasswordHash = "WIU25RPK2DX",
                    PhoneNumber = "0765623808",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("4c494db9-2072-b27e-4b55-672aae5e6834")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("13c4b337-5772-2168-4b11-1bf148c1abce")),
                },
                new User{
                    Id = "4E8E4D71-32A7-E43A-B829-042451EA03D3",
                    FirstName = "Quinlan",
                    LastName = "Tate",
                    Email = "varius@urnanuncquis.co.uk",
                    UserName = "varius@urnanuncquis.co.uk",
                    PasswordHash = "KNN55OBP9BD",
                    PhoneNumber = "0723724855",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("867b3bec-cb93-65db-8d21-6f12249a515a")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("32158cb4-cdc9-93ff-cece-35dca5602dfa")),
                },
                new User{
                    Id = "0451E2E0-316D-BD64-C798-DAD8C2E6CF8D",
                    FirstName = "Peter",
                    LastName = "Vance",
                    Email = "ac@malesuadafringilla.co.uk",
                    UserName = "ac@malesuadafringilla.co.uk",
                    PasswordHash = "NSH84RTG6CX",
                    PhoneNumber = "0779821854",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("06520813-f31c-2184-f147-7fb2775762db")),
                },
                new User{
                    Id = "F51B386E-8589-F877-6CB6-D0FA9DE9E3C1",
                    FirstName = "Florence",
                    LastName = "Vargas",
                    Email = "curabitur.vel@volutpat.net",
                    UserName = "curabitur.vel@volutpat.net",
                    PasswordHash = "PWX87SAD8EN",
                    PhoneNumber = "0726330888",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("46be6f28-4190-892e-9650-9584cc92eee7")),

                },
                new User{
                    Id = "4CCB89CC-90A5-A2EA-7938-579BA944699C",
                    FirstName = "Macaulay",
                    LastName = "Mcmahon",
                    Email = "cursus.nunc@felisorci.com",
                    UserName = "cursus.nunc@felisorci.com",
                    PasswordHash = "SHR79WSW1HG",
                    PhoneNumber = "0715138923",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("bc3cd434-46ea-98f1-ee16-96e6a26c665e")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("2518256e-330b-57b4-c612-57d7bb7e37b2")),
                },
                new User{
                    Id = "5BA4C614-893A-9EEC-A1DE-01114C4634C7",
                    FirstName = "Alana",
                    LastName = "Matthews",
                    Email = "ipsum.cursus.vestibulum@vestibulummassa.com",
                    UserName = "ipsum.cursus.vestibulum@vestibulummassa.com",
                    PasswordHash = "BFY81PDP1MT",
                    PhoneNumber = "0713329746",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("5aac2dfc-ad1a-aa4e-01c9-b668824c5755")),
                },
                new User{
                    Id = "3D72D1CD-A74C-DBEA-15EA-C7CB2683EE67",
                    FirstName = "Beatrice",
                    LastName = "Boyer",
                    Email = "mauris.magna@enimmi.com",
                    UserName = "mauris.magna@enimmi.com",
                    PasswordHash = "GEY67YZV3EV",
                    PhoneNumber = "0776327606",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("02fac50c-519b-0619-6eed-c15f9366a811")),
                },
                new User{
                    Id = "AEC36773-6E66-3C8E-2456-0542B025AA66",
                    FirstName = "Nolan",
                    LastName = "Butler",
                    Email = "semper.pretium.neque@sedpedecum.edu",
                    UserName = "semper.pretium.neque@sedpedecum.edu",
                    PasswordHash = "LPF26KFD5EW",
                    PhoneNumber = "0736086653",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("a5aea169-2978-d12d-0e88-ceb342b7eeb5")),
                },
                new User{
                    Id = "68A18655-9830-6318-6E08-1D4E9AADC7E5",
                    FirstName = "Bradley",
                    LastName = "Barron",
                    Email = "sit@loremsit.com",
                    UserName = "sit@loremsit.com",
                    PasswordHash = "OVC91HPE0HG",
                    PhoneNumber = "0725947864",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("8a92df59-e3a7-4452-abdd-d93a32ec59d8")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("8d69ec5a-8e69-4c9f-30b9-b1d4963f6cd3")),
                },
                new User{
                    Id = "7584A1AD-3579-F167-4172-D6CF75352D89",
                    FirstName = "Mariam",
                    LastName = "Reid",
                    Email = "quam.quis.diam@tinciduntadipiscing.com",
                    UserName = "quam.quis.diam@tinciduntadipiscing.com",
                    PasswordHash = "ENK77TNO6OR",
                    PhoneNumber = "0758181878",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("41250536-4c1e-874b-7a7c-de25b8a53a1c")),
                },
                new User{
                    Id = "733AF80E-FAEF-1E00-4FC7-1E5DAAC5E36A",
                    FirstName = "Fleur",
                    LastName = "Mcdaniel",
                    Email = "et.netus@rhoncus.ca",
                    UserName = "et.netus@rhoncus.ca",
                    PasswordHash = "NUP29WXH8FS",
                    PhoneNumber = "0717171015",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("319ebe58-dbed-2ac9-27b3-e5e2ad8681b1")),
                    ShippingAdress = context.ShippingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("2c288b88-a3b2-1594-d8da-da934269563e")),
                },
                new User{
                    Id = "3AB2C925-1558-EDC3-B43A-5698EF1432E7",
                    FirstName = "Tobias",
                    LastName = "Salinas",
                    Email = "orci.phasellus@afeugiattellus.ca",
                    UserName = "orci.phasellus@afeugiattellus.ca",
                    PasswordHash = "FPL23PGG8FI",
                    PhoneNumber = "0738782887",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("fd632ec7-08a4-5b56-32de-eb4e865237c9")),
                },
                new User{
                    Id = "99A9293B-1062-CE1A-661C-0AD7D53DE571",
                    FirstName = "Barclay",
                    LastName = "Morrow",
                    Email = "ipsum.dolor@egestas.org",
                    UserName = "ipsum.dolor@egestas.org",
                    PasswordHash = "KJC72GKJ3IQ",
                    PhoneNumber = "0708748798",
                    BillingAdress = context.BillingAdresses.SingleOrDefault(b=>b.Id == Guid.Parse("d2bb6a49-5e88-70e4-8e43-024be14ba393"))
                }
            };
            await context.Users.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateAttributeType(DataContext context)
        {
            if (context.AttributeTypes.Any()) return;

            var data = new List<AttributeType>
            {
                new AttributeType{
                    Id = Guid.Parse("069B5124-E598-757E-EE62-E21147864E35"),
                    Name = "Size"
                },
                new AttributeType{
                    Id = Guid.Parse("3733C26D-2611-BB9C-8D68-16AD4104467E"),
                    Name = "Color"
                }
            };
            await context.AttributeTypes.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateProductAttribute(DataContext context)
        {
            if (context.ProductAttributes.Any()) return;

            var data = new List<ProductAttribute>
            {
                new ProductAttribute{
                    Id = Guid.Parse("B46BBD5A-A585-FD85-6E6D-EA8864DC77E7"),
                    Name = "Black",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("82BD1712-7670-C69E-7BB9-7F347324B6B6"),
                    Name = "Gray",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("3C2482D3-CE9A-9640-28B0-46821B786179"),
                    Name = "White",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("D887516F-EED8-B8EF-6290-76E07E7CD9DA"),
                    Name = "Beige",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("AE8FBDA3-D444-EFDB-56DB-E43967FFBD46"),
                    Name = "Brown",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("B2AAA69A-CD39-1D6B-79D6-921CFC724D18"),
                    Name = "Blue",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("6D36A32A-A7EA-F14D-1511-F1DCC7DD73D1"),
                    Name = "Dark Blue",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("AC558A3C-AEF8-077C-BC03-2EDC1684126B"),
                    Name = "Purple",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("786483CD-41F4-7888-4B93-B0958906472C"),
                    Name = "Pink",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("EDB14DB9-E100-5EC1-3BCC-9116B4ED84AE"),
                    Name = "Red",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("BEF5B56C-1DB5-A595-DD2C-A1E95AC1862A"),
                    Name = "Orange",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("ABF567B4-8818-6499-861E-85A167D4D7E4"),
                    Name = "Peach",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("50E21DE9-25C9-EB65-98F3-A0ECB17D165D"),
                    Name = "Yellow",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("EBA3F93E-6C70-0456-4C42-8CD2D4B3D47D"),
                    Name = "Light Green",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("32C2A0A4-930E-93DA-5710-10311423296A"),
                    Name = "Green",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("AF251996-038A-874C-2582-17D8547C1311"),
                    Name = "Teal",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("9BC52664-95D2-1B38-2C5E-5538D4C27AFE"),
                    Name = "Turquoise",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("A0C257E1-774C-443D-1801-325256E8FD7C"),
                    Name = "Silver",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("D0A65797-4A8E-066B-A8B7-FD79E5D9E091"),
                    Name = "Gold",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("65BA0754-E4A6-DCEC-7517-C9588224CA9B"),
                    Name = "Multi Colored",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Color")
                },
                new ProductAttribute{
                    Id = Guid.Parse("AC9F51D8-B4B6-399B-E181-C93D2D1371CB"),
                    Name = "S",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("686E8508-34E9-688D-D83C-56D4D8234B85"),
                    Name = "M",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("C4C84BEC-D727-35D9-03FB-46DB89CC494C"),
                    Name = "L",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("B1EEAE42-C98D-5841-A9DC-C48692795199"),
                    Name = "XL",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("B3A84B37-38B7-3A48-BB41-B2AED774E59E"),
                    Name = "XXL",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("CD0925CE-AE83-7D67-515F-425B8CA18193"),
                    Name = "XXXL",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                },
                new ProductAttribute{
                    Id = Guid.Parse("4BF38547-CD1C-0874-8D78-85CE3441C460"),
                    Name = "One Size",
                    AttributeType = context.AttributeTypes.SingleOrDefault(att=>att.Name == "Size")
                }
            };
            await context.ProductAttributes.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateCategory(DataContext context)
        {
            if (context.Categories.Any()) return;

            var data = new List<Category>
                {
                    new Category{
                        Id = Guid.Parse("916B9A59-9347-BB44-53ED-E96EE9B87D66"),
                        Name = "Skateboard"
                    },
                    new Category{
                        Id = Guid.Parse("523A7ECE-1ED5-F315-33D0-17B52236E614"),
                        Name = "Skateboard wheels"
                    },
                    new Category{
                        Id = Guid.Parse("D24726B6-32D9-3198-DECC-436B593866D4"),
                        Name = "Hoodie"
                    },
                    new Category{
                        Id = Guid.Parse("2E62FF48-D7C5-EDD6-360A-151A323AA217"),
                        Name = "T-Shirt"
                    },
                    new Category{
                        Id = Guid.Parse("99527349-203D-35CE-F67B-D8DA3E153AD2"),
                        Name = "Cap"
                    }
                };
            await context.Categories.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateProductGroup(DataContext context)
        {
            if (context.ProductGroups.Any()) return;

            var data = new List<ProductGroup>
                {
                    new ProductGroup{
                        Id = Guid.Parse("E518B1B3-82D8-0C65-D5BD-CC68F6CC7EE1"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Red"),
                        Thumbnail = "1591-1-1.png",
                        BgColor = "ed2f45"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("E169DCAD-CE7C-86FC-3AB3-72BE5CB23416"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Blue"),
                        Thumbnail = "1591-2-1.png",
                        BgColor = "32a0cc"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("9011B09F-43D5-6380-F553-467432D4DB00"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Green"),
                        Thumbnail = "1591-3-1.png",
                        BgColor ="058232",
                    },
                    new ProductGroup{
                        Id = Guid.Parse("CC8E7151-6D36-6D67-E186-C499116C7147"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Pink"),
                        Thumbnail = "1591-4-1.png",
                        BgColor = "d76b96",
                    },
                    new ProductGroup{
                        Id = Guid.Parse("371746D2-EF5E-1A9C-EEE3-114ACE479AAD"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "White"),
                        Thumbnail = "1591-5-1.png",
                        BgColor = "a3a3a3"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("A687A619-0B81-382C-EC3E-55C2273CD21F"),
                        ParrentSku = "1591",
                        Title ="Skate Sinus Ecy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "1591-6-1.png"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("708E3ECC-A094-8E73-3C1C-631BBD1551A7"),
                        ParrentSku = "2591",
                        Title ="Skate Sinus Decor",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Orange"),
                        Thumbnail = "2591-1-1.png",
                        BgColor = "3f3d37"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("1752404A-E0D7-E257-1BD4-41AB232B2BEB"),
                        ParrentSku = "2591",
                        Title ="Skate Sinus Decor",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Dark Blue"),
                        Thumbnail = "2591-2-1.png",
                        BgColor = "775093"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("D3656738-3317-92F8-3E05-269D91B51684"),
                        ParrentSku = "2591",
                        Title ="Skate Sinus Decor",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Yellow"),
                        Thumbnail = "2591-3-1.png",
                        BgColor = "aca81e"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("9C2EDC53-1ADB-8E07-AD8D-2DEF617897BB"),
                        ParrentSku = "3591",
                        Title ="Skate Sinus Multi",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "3591-1-1.png",
                        BgColor = "d4949f"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("58463786-78C7-43D9-88A3-30BB5711788C"),
                        ParrentSku = "4591",
                        Title ="Skate Sinus Multi",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "4591-1-1.png",
                        BgColor = "a97f21"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("D5DE51C7-7387-AB30-9BBF-A0F654A883C8"),
                        ParrentSku = "5591",
                        Title ="Skate Sinus Multi",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "5591-1-1.png",
                        BgColor = "571f41"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("E8D8C927-7085-8CA6-755B-5C26C284672E"),
                        ParrentSku = "6591",
                        Title ="Skate Sinus Multi",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "6591-1-1.png",
                        BgColor = "3a215e"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("2807E819-F65F-EE24-4222-F3BCC311ED57"),
                        ParrentSku = "7591",
                        Title ="Skate Sinus Aagle",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "sinus-skateboard-eagle.png",
                        BgColor = "ffc794"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("70419A73-B141-4652-21D3-2E12D9E33B23"),
                        ParrentSku = "8591",
                        Title ="Skate Sinus Fire",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "sinus-skateboard-fire.png",
                        BgColor = "ce3e00"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("5CC59061-C4CA-643B-BEB9-8023D269E854"),
                        ParrentSku = "9591",
                        Title ="Skate Sinus Gretasfury",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "sinus-skateboard-gretasfury.png",
                        BgColor ="53310f"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("7EA7285F-2D67-4C1B-F579-E757242D5F0A"),
                        ParrentSku = "3691",
                        Title ="Skate Sinus Ink",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "sinus-skateboard-ink.png",
                        BgColor ="c67e3d"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("BA155602-690B-5E85-9E34-D6D6432A84C5"),
                        ParrentSku = "4691",
                        Title ="Skate Sinus Northern Lights",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Multi Colored"),
                        Thumbnail = "sinus-skateboard-northern_lights.png",
                        BgColor = "00cf61"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76"),
                        ParrentSku = "12341",
                        Title ="Hoodie Kiruy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "hoodie-ash.png",
                        BgColor = "565656"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17"),
                        ParrentSku = "12341",
                        Title ="Hoodie Kiruy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Red"),
                        Thumbnail = "hoodie-fire.png",
                        BgColor="722622"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267"),
                        ParrentSku = "12341",
                        Title ="Hoodie Kiruy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Green"),
                        Thumbnail = "hoodie-green.png",
                        BgColor ="196230"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488"),
                        ParrentSku = "12341",
                        Title ="Hoodie Kiruy",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Blue"),
                        Thumbnail = "hoodie-ocean.png",
                        BgColor="14345b"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60"),
                        ParrentSku = "1234",
                        Title ="Hoodie Hudu",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "White"),
                        Thumbnail = "1234-1-1.png",
                        BgColor ="b4b5af"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266"),
                        ParrentSku = "1234",
                        Title ="Hoodie Hudu",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Gray"),
                        Thumbnail = "1234-2-1.png",
                        BgColor="75767b"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284"),
                        ParrentSku = "1234",
                        Title ="Hoodie Hudu",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "1234-3-1.png",
                        BgColor="2c2c2c"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9"),
                        ParrentSku = "2234",
                        Title ="Hoodie Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "White"),
                        Thumbnail = "2234-1-1.png",
                        BgColor="e7e0d7"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94"),
                        ParrentSku = "2234",
                        Title ="Hoodie Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Blue"),
                        Thumbnail = "2234-2-1.png",
                        BgColor ="b0cfeb"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638"),
                        ParrentSku = "2234",
                        Title ="Hoodie Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Hoodie"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "2234-3-1.png",
                        BgColor="4b4f69"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E"),
                        ParrentSku = "7894",
                        Title ="T-shirt Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "T-shirt"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Blue"),
                        Thumbnail = "7894-1-1.png",
                        BgColor="6583e8"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74"),
                        ParrentSku = "7894",
                        Title ="T-shirt Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "T-shirt"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Red"),
                        Thumbnail = "7894-2-1.png",
                        BgColor="820007"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823"),
                        ParrentSku = "8894",
                        Title ="T-shirt Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "T-shirt"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Orange"),
                        Thumbnail = "8894-1-1.png",
                        BgColor="a63900"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B"),
                        ParrentSku = "8894",
                        Title ="T-shirt Sinus",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "T-shirt"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "8894-2-1.png",
                        BgColor="4b4b4b"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("56FD6379-4960-255F-1494-4A85362B4562"),
                        ParrentSku = "14522",
                        Title ="Caps",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Cap"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Blue"),
                        Thumbnail = "sinus-cap-blue.png",
                        BgColor="213484"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("56FD4379-4960-255F-1494-4A85362B4562"),
                        ParrentSku = "14522",
                        Title ="Caps",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Cap"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Green"),
                        Thumbnail = "sinus-cap-green.png",
                        BgColor="227e14"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("56FD3379-4960-255F-1494-4A85362B4562"),
                        ParrentSku = "14522",
                        Title ="Caps",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Cap"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Purple"),
                        Thumbnail = "sinus-cap-purple.png",
                        BgColor="4d1d68"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("56FD1379-4960-255F-1494-4A85362B4562"),
                        ParrentSku = "14522",
                        Title ="Caps",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Cap"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Red"),
                        Thumbnail = "sinus-cap-red.png",
                        BgColor="770c0e"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("02338A33-7B0C-1E5F-33CE-275A13C1D5E3"),
                        ParrentSku = "12",
                        Title ="Wheel",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard wheels"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Red"),
                        Thumbnail = "sinus-wheel-rocket.png",
                        BgColor="6a7863"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("03338A33-7B0C-1E5F-33CE-275A13C1D5E3"),
                        ParrentSku = "12",
                        Title ="Wheel",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard wheels"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "White"),
                        Thumbnail = "sinus-wheel-spinner.png",
                        BgColor="6a7863"
                    },
                    new ProductGroup{
                        Id = Guid.Parse("01338A33-7B0C-1E5F-33CE-275A13C1D5E3"),
                        ParrentSku = "12",
                        Title ="Wheel",
                        ShortDescription = GetShortDescription(),
                        DetailDescription = GetDescription(),
                        Category = context.Categories.SingleOrDefault(cat=>cat.Name == "Skateboard wheels"),
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "Black"),
                        Thumbnail = "sinus-wheel-wave.png",
                        BgColor="6a7863"
                    }
                };
            await context.ProductGroups.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateImage(DataContext context)
        {
            if (context.Images.Any()) return;

            var data = new List<Image>
                    {
                        new Image{
                            Id = Guid.Parse("CDFCBDE8-3C88-FE98-3B89-133E19CAFAF8"),
                            Path = "1591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E518B1B3-82D8-0C65-D5BD-CC68F6CC7EE1")),
                        },
                        new Image{
                            Id = Guid.Parse("93CB32DE-D17E-7571-58D4-4564B6485272"),
                            Path = "1591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E518B1B3-82D8-0C65-D5BD-CC68F6CC7EE1")),
                        },
                        new Image{
                            Id = Guid.Parse("417FF831-A259-6912-8A0E-51FABFE5E502"),
                            Path = "1591-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E169DCAD-CE7C-86FC-3AB3-72BE5CB23416")),
                        },
                        new Image{
                            Id = Guid.Parse("91FAE523-85A4-39E7-3BC3-AA662BD535B2"),
                            Path = "1591-2-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E169DCAD-CE7C-86FC-3AB3-72BE5CB23416")),
                        },
                        new Image{
                            Id = Guid.Parse("79A2114D-BDAA-C4EA-35BC-1CBE24531D92"),
                            Path = "1591-3-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("9011B09F-43D5-6380-F553-467432D4DB00")),
                        },
                        new Image{
                            Id = Guid.Parse("51CB8898-9B6B-BC7D-C996-3763F7788CCE"),
                            Path = "1591-3-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("9011B09F-43D5-6380-F553-467432D4DB00")),
                        },
                        new Image{
                            Id = Guid.Parse("022911C4-1B97-F5B9-B212-AA79455DD5E6"),
                            Path = "1591-4-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("CC8E7151-6D36-6D67-E186-C499116C7147")),
                        },
                        new Image{
                            Id = Guid.Parse("F8C3A715-94FC-59CC-15E1-DB8728891EF2"),
                            Path = "1591-4-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("CC8E7151-6D36-6D67-E186-C499116C7147")),
                        },
                        new Image{
                            Id = Guid.Parse("EF854CDA-6A05-0FA2-520C-3FBA3EAC8373"),
                            Path = "1591-5-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("371746D2-EF5E-1A9C-EEE3-114ACE479AAD")),
                        },
                        new Image{
                            Id = Guid.Parse("DB3F93EE-66AE-DC44-5991-6D6A4A3EE5D6"),
                            Path = "1591-5-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("371746D2-EF5E-1A9C-EEE3-114ACE479AAD")),
                        },
                        new Image{
                            Id = Guid.Parse("C4979628-110E-204B-ED1C-2EB9423C3B82"),
                            Path = "1591-6-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("A687A619-0B81-382C-EC3E-55C2273CD21F")),
                        },
                        new Image{
                            Id = Guid.Parse("7E8BB9AB-DB6F-5C5C-14E8-8AAA4933D892"),
                            Path = "1591-6-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("A687A619-0B81-382C-EC3E-55C2273CD21F")),
                        },
                        new Image{
                            Id = Guid.Parse("52968B71-C7DE-5370-218D-51AA5D1578B6"),
                            Path = "2591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("708E3ECC-A094-8E73-3C1C-631BBD1551A7")),
                        },
                        new Image{
                            Id = Guid.Parse("6E1771E6-B146-2E94-5C76-E81B5323D671"),
                            Path = "2591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("708E3ECC-A094-8E73-3C1C-631BBD1551A7")),
                        },
                        new Image{
                            Id = Guid.Parse("812C12F8-1334-3BB8-1D36-885F4512B835"),
                            Path = "2591-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("1752404A-E0D7-E257-1BD4-41AB232B2BEB")),
                        },
                        new Image{
                            Id = Guid.Parse("CA476174-9FBA-BA3C-39C1-E79AEAEC6275"),
                            Path = "2591-2-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("1752404A-E0D7-E257-1BD4-41AB232B2BEB")),
                        },
                        new Image{
                            Id = Guid.Parse("24B9C14B-1C84-1DA8-CEE2-B1A56F2E587C"),
                            Path = "2591-3-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("D3656738-3317-92F8-3E05-269D91B51684")),
                        },
                        new Image{
                            Id = Guid.Parse("BC266C75-BC0A-6DA2-D072-1191B463D2CD"),
                            Path = "2591-3-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("D3656738-3317-92F8-3E05-269D91B51684")),
                        },
                        new Image{
                            Id = Guid.Parse("B5D5E50C-1D57-1584-3C5D-AF412A8A9D54"),
                            Path = "3591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("9C2EDC53-1ADB-8E07-AD8D-2DEF617897BB")),
                        },
                        new Image{
                            Id = Guid.Parse("1E821385-BD44-3288-8E77-12A8BA8D6426"),
                            Path = "3591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("9C2EDC53-1ADB-8E07-AD8D-2DEF617897BB")),
                        },
                        new Image{
                            Id = Guid.Parse("1AB6549E-112D-98C7-8131-3332171D39A1"),
                            Path = "4591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("58463786-78C7-43D9-88A3-30BB5711788C")),
                        },
                        new Image{
                            Id = Guid.Parse("A8C37FEC-A4DD-B1D2-6E7E-7869E10BCAE9"),
                            Path = "4591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("58463786-78C7-43D9-88A3-30BB5711788C")),
                        },
                        new Image{
                            Id = Guid.Parse("BD843D73-A817-58B5-B264-ECE9A6179729"),
                            Path = "5591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("D5DE51C7-7387-AB30-9BBF-A0F654A883C8")),
                        },
                        new Image{
                            Id = Guid.Parse("EBB789D4-B97C-BBE8-BD32-9222E14D1B97"),
                            Path = "5591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("D5DE51C7-7387-AB30-9BBF-A0F654A883C8")),
                        },
                        new Image{
                            Id = Guid.Parse("4EA1A697-72AF-AB94-7C6F-528598BE86A1"),
                            Path = "6591-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E8D8C927-7085-8CA6-755B-5C26C284672E")),
                        },
                        new Image{
                            Id = Guid.Parse("2B929C23-26BA-5AA9-34AA-C5A87C8A8744"),
                            Path = "6591-1-3.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("E8D8C927-7085-8CA6-755B-5C26C284672E")),
                        },
                        new Image{
                            Id = Guid.Parse("5E02542E-DD2D-38C3-1267-DCD7BC8A4C6C"),
                            Path = "1234-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                        },
                        new Image{
                            Id = Guid.Parse("666CE59E-2E83-E6A3-8992-D54FC33B6233"),
                            Path = "1234-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                        },
                        new Image{
                            Id = Guid.Parse("C11DE9E4-BBFD-8CC4-4B63-54E908A8701A"),
                            Path = "1234-3-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                        },
                        new Image{
                            Id = Guid.Parse("299CE8D9-B456-88BF-C93C-7E553CAF6A39"),
                            Path = "2234-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                        },
                        new Image{
                            Id = Guid.Parse("CD9E4DB6-CC88-C483-AD8C-AD5A46A016EF"),
                            Path = "2234-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                        },
                        new Image{
                            Id = Guid.Parse("41931339-5DB1-8553-6A23-C528A4D5374B"),
                            Path = "2234-3-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                        },
                        new Image{
                            Id = Guid.Parse("72B5D224-DAC7-B23A-44B9-87D1BC883805"),
                            Path = "7894-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                        },
                        new Image{
                            Id = Guid.Parse("F3688821-F52E-3A2F-6298-15BE43F27DF9"),
                            Path = "7894-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                        },
                        new Image{
                            Id = Guid.Parse("B5E71B32-2618-C8C3-E834-9045DE1CD4BD"),
                            Path = "8894-1-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                        },
                        new Image{
                            Id = Guid.Parse("1DD2FF9B-675B-D399-C593-4D7F9A614E21"),
                            Path = "8894-2-2.png",
                            ProductGroup = context.ProductGroups.SingleOrDefault(p=>p.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                        }
                    };
            await context.Images.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateOrderStatus(DataContext context)
        {
            if (context.OrderStatuses.Any()) return;

            var data = new List<OrderStatus>
                {
                    new OrderStatus{
                        Id = Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8"),
                        Name = "Processing"
                    },
                    new OrderStatus{
                        Id = Guid.Parse("9D5D3B2B-C2C7-841D-66AB-DDBB45110DDC"),
                        Name = "Cancelled"
                    },
                    new OrderStatus{
                        Id = Guid.Parse("3C796899-5C93-46D9-A019-EADD3E6258C7"),
                        Name = "Refunded"
                    },
                    new OrderStatus{
                        Id = Guid.Parse("6C848988-8230-2B8B-AE9C-83675675C957"),
                        Name = "Delivered"
                    }
                };
            await context.OrderStatuses.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        private static string GetShortDescription()
        {
            return "Tellus sem mollis dui, in sodales elit erat vitae risus. Duis a mi fringilla mi";
        }
        private static string GetDescription()
        {
            return "Consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum magna. Ut tincidunt orci quis lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus faucibus leo, in lobortis tellus justo sit amet nulla. Donec non justo. Proin non massa non ante bibendum ullamcorper. Duis cursus, diam at pretium aliquet, metus urna convallis erat, eget tincidunt dui augue eu.";
        }
        public static async Task GenerateProduct(DataContext context)
        {
            if (context.Products.Any()) return;

            var data = new List<Product>
                {
                    new Product{
                        Id = Guid.Parse("BD26699E-6653-713C-239D-335C97E1B026"),
                        Sku = "11",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("E518B1B3-82D8-0C65-D5BD-CC68F6CC7EE1")),
                    },
                    new Product{
                        Id = Guid.Parse("EA67386B-C916-D326-D9A4-98E6E5BE982B"),
                        Sku = "12",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 66,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("E169DCAD-CE7C-86FC-3AB3-72BE5CB23416")),
                    },
                    new Product{
                        Id = Guid.Parse("3ACA2141-5A46-E33F-809C-A55135AAB7D8"),
                        Sku = "13",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 54,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("9011B09F-43D5-6380-F553-467432D4DB00")),
                    },
                    new Product{
                        Id = Guid.Parse("5BECAA55-ABB4-D16D-2591-5574A8EAEDFD"),
                        Sku = "14",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("CC8E7151-6D36-6D67-E186-C499116C7147")),
                    },
                    new Product{
                        Id = Guid.Parse("64DB9C5A-FAE8-E3E9-1A78-73DCC5F0FE46"),
                        Sku = "15",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("371746D2-EF5E-1A9C-EEE3-114ACE479AAD")),
                    },
                    new Product{
                        Id = Guid.Parse("C5667B98-3C23-A1B6-05FE-671655346596"),
                        Sku = "16",
                        Price = 399,
                        DiscountedPrice = 299,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A687A619-0B81-382C-EC3E-55C2273CD21F")),
                    },
                    new Product{
                        Id = Guid.Parse("EB8FA518-C37E-B16E-1E1F-F7FBD32E56A3"),
                        Sku = "21",
                        Price = 299,
                        Stock= 56,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("708E3ECC-A094-8E73-3C1C-631BBD1551A7")),
                    },
                    new Product{
                        Id = Guid.Parse("64D57B94-4EC5-BE53-4E30-27FCBA8B3583"),
                        Sku = "22",
                        Price = 299,
                        Stock= 15,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1752404A-E0D7-E257-1BD4-41AB232B2BEB")),
                    },
                    new Product{
                        Id = Guid.Parse("84202AC2-826C-B6BB-B6F8-AD6313AF6FED"),
                        Sku = "23",
                        Price = 299,
                        Stock= 11,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D3656738-3317-92F8-3E05-269D91B51684")),
                    },
                    new Product{
                        Id = Guid.Parse("AB47F6E8-7547-49F8-1502-937B38FBA898"),
                        Sku = "31",
                        Price = 699,
                        DiscountedPrice = 559,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("9C2EDC53-1ADB-8E07-AD8D-2DEF617897BB")),
                    },
                    new Product{
                        Id = Guid.Parse("E7B44101-423B-0967-6EEA-077D3F81E35C"),
                        Sku = "41",
                        Price = 639,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("58463786-78C7-43D9-88A3-30BB5711788C")),
                    },
                    new Product{
                        Id = Guid.Parse("B7792118-8644-3234-9DA7-F8335BB66270"),
                        Sku = "51",
                        Price = 589,
                        DiscountedPrice = 519,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5DE51C7-7387-AB30-9BBF-A0F654A883C8")),
                    },
                    new Product{
                        Id = Guid.Parse("FEBBA75B-68DF-6E18-1CEA-E1AEC911CB56"),
                        Sku = "61",
                        Price = 699,
                        DiscountedPrice = 559,
                        Stock= 33,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("E8D8C927-7085-8CA6-755B-5C26C284672E")),
                    },
                    new Product{
                        Id = Guid.Parse("D12E9681-6D98-428D-D897-573658B4F6BA"),
                        Sku = "71",
                        Price = 669,
                        DiscountedPrice = 599,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("2807E819-F65F-EE24-4222-F3BCC311ED57")),
                    },
                    new Product{
                        Id = Guid.Parse("A1BFE764-9B05-141D-BE8A-661B59D99573"),
                        Sku = "81",
                        Price = 589,
                        DiscountedPrice = 550,
                        Stock= 40,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("70419A73-B141-4652-21D3-2E12D9E33B23")),
                    },
                    new Product{
                        Id = Guid.Parse("E7A806A4-DC83-6586-E5A2-6C1294BB2592"),
                        Sku = "91",
                        Price = 399,
                        DiscountedPrice = 199,
                        Stock= 8,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("5CC59061-C4CA-643B-BEB9-8023D269E854")),
                    },
                    new Product{
                        Id = Guid.Parse("82358714-8707-7ECA-6EA7-F3276187B096"),
                        Sku = "311",
                        Price = 559,
                        Stock= 6,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("7EA7285F-2D67-4C1B-F579-E757242D5F0A")),
                    },
                    new Product{
                        Id = Guid.Parse("45E7408B-8ACE-9896-4185-7D2BDF6B0251"),
                        Sku = "411",
                        Price = 559,
                        Stock= 6,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("7EA7285F-2D67-4C1B-F579-E757242D5F0A")),
                    },
                    new Product{
                        Id = Guid.Parse("43E7408B-8ACE-9896-4185-7D2BDF6B0251"),
                        Sku = "411",
                        Price = 559,
                        Stock= 9,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA155602-690B-5E85-9E34-D6D6432A84C5")),
                    },
                    new Product{
                        Id = Guid.Parse("758BCD29-3E28-E21A-846E-9536CAE63B22"),
                        Sku = "1S",
                        Price = 199,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76")),
                    },
                    new Product{
                        Id = Guid.Parse("93ACA37D-B54D-5C6A-66E0-2545E8CE5A4B"),
                        Sku = "1M",
                        Price = 199,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76")),
                    },
                    new Product{
                        Id = Guid.Parse("C9C67664-DFB5-F710-E3C3-48C27AAC24FD"),
                        Sku = "1L",
                        Price = 199,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76")),
                    },
                    new Product{
                        Id = Guid.Parse("42B8D22C-37E8-2C72-6544-D11C67B91721"),
                        Sku = "1XL",
                        Price = 199,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76")),
                    },
                    new Product{
                        Id = Guid.Parse("65641714-D5E4-42B4-69C4-B2D79CF767BB"),
                        Sku = "1XXL",
                        Price = 199,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("90074E25-2055-A8FD-B2B6-7561BD28AD76")),
                    },
                    new Product{
                        Id = Guid.Parse("138D9842-4DD6-28B3-65CE-DF257A43A7F8"),
                        Sku = "2S",
                        Price = 199,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17")),
                    },
                    new Product{
                        Id = Guid.Parse("E2B4F258-AD45-46DB-762D-CEBAF94132C6"),
                        Sku = "2M",
                        Price = 199,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17")),
                    },
                    new Product{
                        Id = Guid.Parse("B544BD4B-6811-933D-11EC-3E927CEC1A8D"),
                        Sku = "2L",
                        Price = 199,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17")),
                    },
                    new Product{
                        Id = Guid.Parse("33FDDC3C-31CF-2687-57D4-F0F36B776969"),
                        Sku = "2XL",
                        Price = 199,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17")),
                    },
                    new Product{
                        Id = Guid.Parse("ED3BEF4B-307A-9684-FE02-59C8A76EC331"),
                        Sku = "2XXL",
                        Price = 199,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BCCB8ED9-33B8-D24D-C149-E9A596791B17")),
                    },
                    new Product{
                        Id = Guid.Parse("9DC31B4C-A6DB-417C-511C-8608B2698791"),
                        Sku = "3S",
                        Price = 199,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267")),
                    },
                    new Product{
                        Id = Guid.Parse("02DA8436-6E8D-9743-25C6-F3F2D3EA79B2"),
                        Sku = "3M",
                        Price = 199,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267")),
                    },
                    new Product{
                        Id = Guid.Parse("24A4D9E4-4E54-ABB5-410A-A42006823023"),
                        Sku = "3L",
                        Price = 199,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267")),
                    },
                    new Product{
                        Id = Guid.Parse("D0141AFC-D23D-B8E6-2984-D257CBE1C1CB"),
                        Sku = "3XL",
                        Price = 199,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267")),
                    },
                    new Product{
                        Id = Guid.Parse("ADF8E713-0C2D-6127-4E4D-6B5A25EFD970"),
                        Sku = "3XXL",
                        Price = 199,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("4E1A5508-C64E-F3C5-02B6-90967483C267")),
                    },
                    new Product{
                        Id = Guid.Parse("51426E37-B5EA-1CC8-065D-5FC9E2D2E8EA"),
                        Sku = "4S",
                        Price = 199,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488")),
                    },
                    new Product{
                        Id = Guid.Parse("BC15BA1C-C745-5515-8687-1E3AD443A8D5"),
                        Sku = "4M",
                        Price = 199,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488")),
                    },
                    new Product{
                        Id = Guid.Parse("AE7818A7-1F87-592E-7445-349646D51564"),
                        Sku = "4L",
                        Price = 199,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488")),
                    },
                    new Product{
                        Id = Guid.Parse("40873463-3D7C-6859-8818-8C70BA9E9703"),
                        Sku = "4XL",
                        Price = 199,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488")),
                    },
                    new Product{
                        Id = Guid.Parse("6E453611-BCEC-D2F6-87B5-4443C26E6A13"),
                        Sku = "4XXL",
                        Price = 199,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03D829BD-B2C4-1E61-EF91-97619F5D1488")),
                    },
                    new Product{
                        Id = Guid.Parse("AB9A65B1-4D3B-4456-20C7-B251182ADCA8"),
                        Sku = "5S",
                        Price = 159,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                    },
                    new Product{
                        Id = Guid.Parse("C2DE7EC7-7731-569A-FBE1-B355D4FA9AA9"),
                        Sku = "5M",
                        Price = 159,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                    },
                    new Product{
                        Id = Guid.Parse("51F927C4-14F8-D791-7D26-165ADE914FD5"),
                        Sku = "5L",
                        Price = 159,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                    },
                    new Product{
                        Id = Guid.Parse("61929421-E04A-E021-D7BD-8948DBBFCE0E"),
                        Sku = "5XL",
                        Price = 159,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                    },
                    new Product{
                        Id = Guid.Parse("BE412D51-7CCA-5C55-3FC3-8831577AD96B"),
                        Sku = "5XXL",
                        Price = 159,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("C2B91668-D251-8DC1-E5EC-6D05EB4E2B60")),
                    },
                    new Product{
                        Id = Guid.Parse("69569742-6A3C-AE88-3A3A-27BA55ACB92D"),
                        Sku = "6S",
                        Price = 159,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                    },
                    new Product{
                        Id = Guid.Parse("43CDD412-1BB9-A844-3CE3-7E533A3B246B"),
                        Sku = "6M",
                        Price = 159,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                    },
                    new Product{
                        Id = Guid.Parse("699998DD-D6B3-1DDB-E7B5-1047AEBB7D2A"),
                        Sku = "6L",
                        Price = 159,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                    },
                    new Product{
                        Id = Guid.Parse("8DFC13A9-9D67-0759-FCFB-66346B19B82C"),
                        Sku = "6XL",
                        Price = 159,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                    },
                    new Product{
                        Id = Guid.Parse("0BB4FCD9-E962-F34D-BEE7-EE892EEEF0B2"),
                        Sku = "6XXL",
                        Price = 159,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("D5EB17C5-4D3F-D255-4615-A619E5CEC266")),
                    },
                    new Product{
                        Id = Guid.Parse("2973D963-2C88-A9A0-2014-7BEE1840B149"),
                        Sku = "7S",
                        Price = 159,
                        Stock= 12,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                    },
                    new Product{
                        Id = Guid.Parse("567D45A6-22C8-E1B5-84A6-21DFDE7F5BDD"),
                        Sku = "7M",
                        Price = 159,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                    },
                    new Product{
                        Id = Guid.Parse("44235EEF-58E3-A333-33B2-162243838A4A"),
                        Sku = "7L",
                        Price = 159,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                    },
                    new Product{
                        Id = Guid.Parse("08310E74-AF19-889F-CB06-633C6B883111"),
                        Sku = "7XL",
                        Price = 159,
                        Stock= 16,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                    },
                    new Product{
                        Id = Guid.Parse("8D7A4EE2-8F25-6CA4-8683-9CE137864A78"),
                        Sku = "7XXL",
                        Price = 159,
                        Stock= 17,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("8209E6B8-46FC-C047-3436-15535187E284")),
                    },
                    new Product{
                        Id = Guid.Parse("B7AA46BA-EBB7-70AE-D5E1-3AA74946F762"),
                        Sku = "8S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                    },
                    new Product{
                        Id = Guid.Parse("C054515F-DE73-C007-E55A-998803A9CC93"),
                        Sku = "8M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                    },
                    new Product{
                        Id = Guid.Parse("024E6DA3-C6EC-BC05-D393-12FC779B7A85"),
                        Sku = "8L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                    },
                    new Product{
                        Id = Guid.Parse("0D868289-A446-C735-4151-462F8F63938C"),
                        Sku = "8XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                    },
                    new Product{
                        Id = Guid.Parse("96574751-A6BB-5C78-79CE-8AE4108E6544"),
                        Sku = "8XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("BA191F77-BECC-BA87-8D2D-C79388B88BB9")),
                    },
                    new Product{
                        Id = Guid.Parse("B2E6E6E7-BA9C-8410-7BCE-A175DA883C8C"),
                        Sku = "9S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                    },
                    new Product{
                        Id = Guid.Parse("EEA93A82-1DE9-80B3-531A-C174BE129A31"),
                        Sku = "9M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                    },
                    new Product{
                        Id = Guid.Parse("CB4551E4-4EB1-8890-711D-D653E3114D22"),
                        Sku = "9L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                    },
                    new Product{
                        Id = Guid.Parse("12E15178-BCC8-39C5-EAB2-519B66C2C7A5"),
                        Sku = "9XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                    },
                    new Product{
                        Id = Guid.Parse("511226BA-8B4F-C821-8943-655998B33769"),
                        Sku = "9XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("1DB44612-4633-06FC-A8AD-A5B5D8DF8D94")),
                    },
                    new Product{
                        Id = Guid.Parse("39C82A63-7DDF-ED85-80CA-5112BABEDC76"),
                        Sku = "10S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                    },
                    new Product{
                        Id = Guid.Parse("9E3CD16C-D118-383B-E81D-1CAA4128B99E"),
                        Sku = "10M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                    },
                    new Product{
                        Id = Guid.Parse("A98E1DF8-6A62-989C-38F4-CF7E9361A539"),
                        Sku = "10L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                    },
                    new Product{
                        Id = Guid.Parse("B80AC48E-8974-5C83-E4D5-2DED300BC2F6"),
                        Sku = "10XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                    },
                    new Product{
                        Id = Guid.Parse("E1A166EC-1539-2B83-F510-D49199D71817"),
                        Sku = "10XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("75A9B614-9086-BBA6-0147-41BD5A258638")),
                    },
                    new Product{
                        Id = Guid.Parse("94349022-EE23-27D9-963A-3F47DF732633"),
                        Sku = "11S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                    },
                    new Product{
                        Id = Guid.Parse("2A4B3E50-4EFD-75D2-316E-6D192C64B87C"),
                        Sku = "11M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                    },
                    new Product{
                        Id = Guid.Parse("BC92061A-8716-E1D1-3FDF-CDB2BDE424A2"),
                        Sku = "11L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                    },
                    new Product{
                        Id = Guid.Parse("22BE13F4-4045-7D11-8682-CCDD844124B7"),
                        Sku = "11XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                    },
                    new Product{
                        Id = Guid.Parse("C644D655-B6A3-1278-B70C-429B21780ECE"),
                        Sku = "11XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("DB0C5E45-753F-6B86-6F4D-F66B9652168E")),
                    },
                    new Product{
                        Id = Guid.Parse("0C8F681D-98F9-C535-67A2-1EF6805132C8"),
                        Sku = "12S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                    },
                    new Product{
                        Id = Guid.Parse("6ECDF76B-9896-C4AA-902D-55B333CC169A"),
                        Sku = "12M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                    },
                    new Product{
                        Id = Guid.Parse("28CE3A91-0EFC-D420-98ED-BA1E92DB59EB"),
                        Sku = "12L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                    },
                    new Product{
                        Id = Guid.Parse("2B12FCBA-3D78-169F-8DC4-EF0EE497BFD5"),
                        Sku = "12XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                    },
                    new Product{
                        Id = Guid.Parse("B72538AE-5262-A7AC-21EA-C441286F7EA0"),
                        Sku = "12XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("B75AB8CC-E0F3-C763-E0E9-665CF5695D74")),
                    },
                    new Product{
                        Id = Guid.Parse("2AA6D82E-2273-EF1D-C622-5A3DD353A78D"),
                        Sku = "13S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                    },
                    new Product{
                        Id = Guid.Parse("D219495B-6D21-BA92-E242-39B872D7EA39"),
                        Sku = "13M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                    },
                    new Product{
                        Id = Guid.Parse("57DE6974-558A-EE85-E9D5-E2B643CD6A74"),
                        Sku = "13L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                    },
                    new Product{
                        Id = Guid.Parse("4746D729-2EB2-8E35-B919-3179BC1A1EB8"),
                        Sku = "13XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                    },
                    new Product{
                        Id = Guid.Parse("12CA566C-7518-EEC6-5425-181B4E5E1C5F"),
                        Sku = "13XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("22425A3D-B1C9-9691-2BDA-87E6A5E8A823")),
                    },
                    new Product{
                        Id = Guid.Parse("163BB20E-959C-5A45-A2AB-77EEB6C905A7"),
                        Sku = "14S",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "S"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                    },
                    new Product{
                        Id = Guid.Parse("44F89FD5-0C97-89D6-C4D1-79978E3EB199"),
                        Sku = "14M",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "M"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                    },
                    new Product{
                        Id = Guid.Parse("6C2919D3-2839-FB71-A9D2-E46620C047BB"),
                        Sku = "14L",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "L"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                    },
                    new Product{
                        Id = Guid.Parse("84E4507A-1120-1B93-854A-9F5DA581553E"),
                        Sku = "14XL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                    },
                    new Product{
                        Id = Guid.Parse("2A71E6D9-5E58-8825-CBCB-FD8E93DE7267"),
                        Sku = "14XXL",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "XXL"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("A96D12ED-BE35-4C32-82AA-A2671ED1703B")),
                    },
                    new Product{
                        Id = Guid.Parse("25DCD18D-3B23-2299-59BA-DDE6B81212AE"),
                        Sku = "1B",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 14,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("56FD6379-4960-255F-1494-4A85362B4562")),
                    },
                    new Product{
                        Id = Guid.Parse("926DAA4A-1D0C-11A3-E33D-5C37235A5782"),
                        Sku = "1G",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 22,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("56FD4379-4960-255F-1494-4A85362B4562")),
                    },
                    new Product{
                        Id = Guid.Parse("6E953E75-E5C7-0750-4BB6-AC280E27EDEE"),
                        Sku = "1P",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 23,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("56FD3379-4960-255F-1494-4A85362B4562")),
                    },
                    new Product{
                        Id = Guid.Parse("12341C21-9FF7-8393-B3A7-BC22B19AE5DE"),
                        Sku = "1R",
                        Price = 199,
                        DiscountedPrice = 149,
                        Stock= 25,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("56FD1379-4960-255F-1494-4A85362B4562")),
                    },
                    new Product{
                        Id = Guid.Parse("349152A4-11B4-E340-8B19-77E983E04B47"),
                        Sku = "2R",
                        Price = 89,
                        Stock= 5,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("02338A33-7B0C-1E5F-33CE-275A13C1D5E3")),
                    },
                    new Product{
                        Id = Guid.Parse("F2E4B73C-7383-BD86-D337-C69430960433"),
                        Sku = "2W",
                        Price = 89,
                        Stock= 6,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("03338A33-7B0C-1E5F-33CE-275A13C1D5E3")),
                    },
                    new Product{
                        Id = Guid.Parse("5B1CF095-4A49-EC55-BEC4-9A7E73C8AF44"),
                        Sku = "2B",
                        Price = 89,
                        Stock= 10,
                        ProductAttribute = context.ProductAttributes.SingleOrDefault(att=>att.Name == "One Size"),
                        ProductGroup = context.ProductGroups.SingleOrDefault(g=>g.Id == Guid.Parse("01338A33-7B0C-1E5F-33CE-275A13C1D5E3")),
                    }
                };
            await context.Products.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
        public static async Task GenerateOrder(DataContext context)
        {
            if (context.Orders.Any()) return;

            var data = new List<Order>
                {
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "284CA552-9B58-88CB-3696-3C895BF35E91"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-25),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("28aa8bdc-126f-159c-74cd-03bb468b615d")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = (decimal)1917,
                        OrderDetails = new List<OrderDetail>{
                             new OrderDetail{
                                 ProductId = Guid.Parse("e7b44101-423b-0967-6eea-077d3f81e35c"),
                                 UnitPrice = 639,
                                 Quantity = 3,
                             }
                         }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "94B98823-44E7-6C92-F4B7-818A7906B658"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-22),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("15c1c447-7b4d-829c-6de6-193ca57a8cba")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("b4c755b5-f4bc-ee4d-0a7c-16cb917ce424")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 557,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("69569742-6a3c-ae88-3a3a-27ba55acb92d"),
                                UnitPrice = 159,
                                Quantity = 1,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("44f89fd5-0c97-89d6-c4d1-79978e3eb199"),
                                UnitPrice = 199,
                                Quantity = 2,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "8C861D4D-83B5-76C2-8CC0-1776D4A5ABA2"),
                        Currency = "EUR",
                        OrderDate = DateTime.Now.AddDays(-19),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("0c2bd9f1-2bc2-d436-bb85-2bd3d98d835d")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("6C848988-8230-2B8B-AE9C-83675675C957")),
                        ShippedDate = DateTime.Now.AddDays(-18),
                        OrderTotal = 41.6M,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("5b1cf095-4a49-ec55-bec4-9a7e73c8af44"),
                                UnitPrice = 8.9M,
                                Quantity = 3,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("c054515f-de73-c007-e55a-998803a9cc93"),
                                UnitPrice = 14.9M,
                                Quantity = 1,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "9EBC7F1E-C2DE-0A7C-B264-95C110B80748"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-18),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("743cea1d-3c83-d25a-3fc4-38c5e824fecb")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("6C848988-8230-2B8B-AE9C-83675675C957")),
                        ShippedDate = DateTime.Now.AddDays(-18),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("12ca566c-7518-eec6-5425-181b4e5e1c5f"),
                                UnitPrice = 149,
                                Quantity = 1,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("4746d729-2eb2-8e35-b919-3179bc1a1eb8"),
                                UnitPrice = 149,
                                Quantity = 1,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "CE002817-C7EB-328B-5056-264D85F2588D"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-16),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("84e04022-bd69-37a4-7021-432624948d39")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 598,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("eb8fa518-c37e-b16e-1e1f-f7fbd32e56a3"),
                                UnitPrice = 299,
                                Quantity = 2,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "16C0AD31-EDBC-376A-37C8-F97BF50E989F"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-16),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("14f42c04-cc97-8eba-8540-477c92ad23f5")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 519,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("b7792118-8644-3234-9da7-f8335bb66270"),
                                UnitPrice = 519,
                                Quantity = 1,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "7C5645C5-BAD8-C999-3782-99BFD513873F"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-15),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("5245d3aa-49d0-d622-ce6a-5374ee9712ca")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("9D5D3B2B-C2C7-841D-66AB-DDBB45110DDC")),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("6c2919d3-2839-fb71-a9d2-e46620c047bb"),
                                UnitPrice = 149,
                                Quantity = 2,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "1E46D7AE-C9DF-6196-08AE-B36113B7186C"),
                        Currency = "EUR",
                        OrderDate = DateTime.Now.AddDays(-14),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("4c494db9-2072-b27e-4b55-672aae5e6834")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("13c4b337-5772-2168-4b11-1bf148c1abce")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("9D5D3B2B-C2C7-841D-66AB-DDBB45110DDC")),
                        OrderTotal = 44.5M,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("f2e4b73c-7383-bd86-d337-c69430960433"),
                                UnitPrice = 8.9M,
                                Quantity = 5,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "4E8E4D71-32A7-E43A-B829-042451EA03D3"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-12),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("867b3bec-cb93-65db-8d21-6f12249a515a")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("32158cb4-cdc9-93ff-cece-35dca5602dfa")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("3C796899-5C93-46D9-A019-EADD3E6258C7")),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("6e953e75-e5c7-0750-4bb6-ac280e27edee"),
                                UnitPrice = 149,
                                Quantity = 2,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "0451E2E0-316D-BD64-C798-DAD8C2E6CF8D"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-11),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("06520813-f31c-2184-f147-7fb2775762db")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("3C796899-5C93-46D9-A019-EADD3E6258C7")),
                        OrderTotal = 598,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("64d57b94-4ec5-be53-4e30-27fcba8b3583"),
                                UnitPrice = 299,
                                Quantity = 2,
                            }
                        }
                     },
                     new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "284CA552-9B58-88CB-3696-3C895BF35E91"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-25),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("28aa8bdc-126f-159c-74cd-03bb468b615d")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 557,
                        OrderDetails = new List<OrderDetail>{
                             new OrderDetail{
                                ProductId = Guid.Parse("69569742-6a3c-ae88-3a3a-27ba55acb92d"),
                                UnitPrice = 159,
                                Quantity = 1,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("44f89fd5-0c97-89d6-c4d1-79978e3eb199"),
                                UnitPrice = 199,
                                Quantity = 2,
                            },
                         }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "94B98823-44E7-6C92-F4B7-818A7906B658"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-22),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("15c1c447-7b4d-829c-6de6-193ca57a8cba")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("b4c755b5-f4bc-ee4d-0a7c-16cb917ce424")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 1917,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                 ProductId = Guid.Parse("e7b44101-423b-0967-6eea-077d3f81e35c"),
                                 UnitPrice = 639,
                                 Quantity = 3,
                             }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "8C861D4D-83B5-76C2-8CC0-1776D4A5ABA2"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-19),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("0c2bd9f1-2bc2-d436-bb85-2bd3d98d835d")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("6C848988-8230-2B8B-AE9C-83675675C957")),
                        ShippedDate = DateTime.Now.AddDays(-18),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("12ca566c-7518-eec6-5425-181b4e5e1c5f"),
                                UnitPrice = 149,
                                Quantity = 1,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("4746d729-2eb2-8e35-b919-3179bc1a1eb8"),
                                UnitPrice = 149,
                                Quantity = 1,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "9EBC7F1E-C2DE-0A7C-B264-95C110B80748"),
                        Currency = "EUR",
                        OrderDate = DateTime.Now.AddDays(-18),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("743cea1d-3c83-d25a-3fc4-38c5e824fecb")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("6C848988-8230-2B8B-AE9C-83675675C957")),
                        ShippedDate = DateTime.Now.AddDays(-18),
                        OrderTotal = 41.6M,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("5b1cf095-4a49-ec55-bec4-9a7e73c8af44"),
                                UnitPrice = 8.9M,
                                Quantity = 3,
                            },
                            new OrderDetail{
                                ProductId = Guid.Parse("c054515f-de73-c007-e55a-998803a9cc93"),
                                UnitPrice = 14.9M,
                                Quantity = 1,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "CE002817-C7EB-328B-5056-264D85F2588D"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-16),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("84e04022-bd69-37a4-7021-432624948d39")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 519,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("b7792118-8644-3234-9da7-f8335bb66270"),
                                UnitPrice = 519,
                                Quantity = 1,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "16C0AD31-EDBC-376A-37C8-F97BF50E989F"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-16),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("14f42c04-cc97-8eba-8540-477c92ad23f5")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("7EB1D4BA-FD32-93EC-7477-3474CD85FAF8")),
                        OrderTotal = 598,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("eb8fa518-c37e-b16e-1e1f-f7fbd32e56a3"),
                                UnitPrice = 299,
                                Quantity = 2,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "7C5645C5-BAD8-C999-3782-99BFD513873F"),
                        Currency = "EUR",
                        OrderDate = DateTime.Now.AddDays(-15),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("5245d3aa-49d0-d622-ce6a-5374ee9712ca")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("9D5D3B2B-C2C7-841D-66AB-DDBB45110DDC")),
                        OrderTotal = 44.5M,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("f2e4b73c-7383-bd86-d337-c69430960433"),
                                UnitPrice = 8.9M,
                                Quantity = 5,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "1E46D7AE-C9DF-6196-08AE-B36113B7186C"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-14),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("4c494db9-2072-b27e-4b55-672aae5e6834")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("13c4b337-5772-2168-4b11-1bf148c1abce")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("9D5D3B2B-C2C7-841D-66AB-DDBB45110DDC")),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("6c2919d3-2839-fb71-a9d2-e46620c047bb"),
                                UnitPrice = 149,
                                Quantity = 2,
                            },
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "4E8E4D71-32A7-E43A-B829-042451EA03D3"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-12),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("867b3bec-cb93-65db-8d21-6f12249a515a")),
                        ShippingAdress = context.ShippingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("32158cb4-cdc9-93ff-cece-35dca5602dfa")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("3C796899-5C93-46D9-A019-EADD3E6258C7")),
                        OrderTotal = 598,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("64d57b94-4ec5-be53-4e30-27fcba8b3583"),
                                UnitPrice = 299,
                                Quantity = 2,
                            }
                        }
                    },
                    new Order{
                        User = context.Users.SingleOrDefault(g=>g.Id == "0451E2E0-316D-BD64-C798-DAD8C2E6CF8D"),
                        Currency = "SEK",
                        OrderDate = DateTime.Now.AddDays(-11),
                        BillingAdress = context.BillingAdresses.SingleOrDefault(g=>g.Id == Guid.Parse("06520813-f31c-2184-f147-7fb2775762db")),
                        OrderStatus = context.OrderStatuses.SingleOrDefault(g=>g.Id == Guid.Parse("3C796899-5C93-46D9-A019-EADD3E6258C7")),
                        OrderTotal = 298,
                        OrderDetails = new List<OrderDetail>{
                            new OrderDetail{
                                ProductId = Guid.Parse("6e953e75-e5c7-0750-4bb6-ac280e27edee"),
                                UnitPrice = 149,
                                Quantity = 2,
                            }
                        }
                     }
                };
            await context.Orders.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
    }
}