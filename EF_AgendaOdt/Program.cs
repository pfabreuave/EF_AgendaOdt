using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AgendaOdt
{
    internal class Program
    {
        //public static object EntityState { get; private set; }
        static void Main(string[] args)
        {
            using (var db = new PacientesContext())
            {
                db.Pacientes.ToList()
                          .ForEach(p => Console.WriteLine(p.ID + " - " + p.CPF + " " + p.NOME + " " + p.DATA_NASCIMENTO + " " + p.DATA_AGENDA + " " + p.HORA_INICIO + " " + p.HORA_FIM));
                Console.WriteLine("1   ----------------------------------------");
                var x = new Paciente();
                x.NOME = "CLAYTON DIVINO";
                x.CPF = "107.233.478-08";
                x.DATA_NASCIMENTO = "18/10/1978";
                x.DATA_AGENDA = "17/08/2022";
                x.HORA_INICIO = 1600;
                x.HORA_FIM = 1700;
                db.Pacientes.Add(x);
                Console.WriteLine("2   ----------------------------------------");
                // ----------------------------------------
                x = db.Pacientes.Find(2);
                x.NOME = "Pedro Savad Abreu P.";
                db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                Console.WriteLine("3   ----------------------------------------");
                // ----------------------------------------
                //x = db.Pacientes.Find(1);
                //db.Pacientes.Remove(x);
                //Console.WriteLine("4   ----------------------------------------");
                // ----------------------------------------

                db.SaveChanges();

                // ----------------------------------------

                db.Pacientes.ToList()
                            .ForEach(p => Console.WriteLine(p.ID + " - " +
                                                            p.CPF + " " + 
                                                            p.NOME + " " + 
                                                            p.DATA_NASCIMENTO + " " + 
                                                            p.DATA_AGENDA + " " + 
                                                            p.HORA_INICIO + " " + 
                                                            p.HORA_FIM));
                Console.ReadKey();
            }
        }
    }
}
