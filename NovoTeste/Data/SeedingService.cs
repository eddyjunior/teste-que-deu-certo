using NovoTeste.Models;
using NovoTeste.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoTeste.Data
{
    public class SeedingService
    {
        private NovoTesteContext _context;

        public SeedingService(NovoTesteContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brow", "bob@gmail.com", new DateTime(1988, 4, 11), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1987, 4, 2), 2200.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1967, 9, 15), 3500.0, d1);
            Seller s4 = new Seller(4, "Edson Junior", "neggoh@gmail.com", new DateTime(1983, 5, 5), 14000.0, d2);
            Seller s5 = new Seller(5, "Donald trump", "terror@gmail.com", new DateTime(1966, 6, 6), 1000000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "pink@gmail.com", new DateTime(1923, 4, 6), 2000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 2, 18), 1200.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 2, 17), 11200.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 2, 1), 200.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 2, 13), 100.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 2, 11), 10200.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 2, 7), 1800.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 2, 3), 900.0, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 2, 8), 100.0, SaleStatus.Billed, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 2, 2), 10.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 2, 27), 31200.0, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 2, 9), 600.0, SaleStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 2, 3), 4200.0, SaleStatus.Billed, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 2, 4), 8200.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 2, 5), 3200.0, SaleStatus.Billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 2, 15), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 2, 12), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 2, 19), 13200.0, SaleStatus.Canceled, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 2, 16), 3200.0, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 2, 20), 4500.0, SaleStatus.Billed, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 2, 21), 500.0, SaleStatus.Billed, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 2, 22), 1100.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 2, 23), 1200.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 2, 13), 1900.0, SaleStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 2, 17), 8300.0, SaleStatus.Billed, s6);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 2, 6), 1300.0, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 2, 2), 300.0, SaleStatus.Billed, s2);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 2, 18), 41200.0, SaleStatus.Billed, s3);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 2, 24), 1400.0, SaleStatus.Billed, s4);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 2, 25), 400.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 2, 26), 15200.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19,
                r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );
            _context.SaveChanges();
        }
    }
}
