﻿using System;
using Persistencia;
using Dominio;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        private static IRMunicipio _repoMunicipio= new RMunicipio(new Persistencia.AppContext());
        static int op=0;
        static void Main(string[] args)


        {

            menu();
        }
        
            private static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("*** MENU DE OPCIONES ***");  //System.out.println()
            Console.WriteLine("1. Crear Municipio");
            Console.WriteLine("2. Buscar Municipio");
            Console.WriteLine("3. Modificar Municipio");
            Console.WriteLine("4. Eliminar Municipio");
            Console.WriteLine("5. Listar Municipios");
            Console.WriteLine();
            Console.WriteLine("Favor selecione una opcion validad (1..5)");

            op=int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                {
                    addMunicipio();
                    break;
                }
                case 2:
                {
                    buscarMunicipio();
                    break;
                }
                case 3:
                {
                    actualizarMunicipio();
                    break;
                }
                case 4:
                {
                    eliminarMunicipio();
                    break;
                }
                case 5:
                {
                    listarMunicipios();
                    break;
                }
                
                default:
                {
                    Console.WriteLine("Error, ingrese una opcion validar ");
                    break;
                }
            }
        

        }

        private static void addMunicipio()
        {
            Municipio objMunicipio=new Municipio();
            Console.WriteLine("Ingrese el nombre del  nuevo municipio");
            objMunicipio.Nombre=Console.ReadLine();
            bool funciono=  _repoMunicipio.CrearMunicipio(objMunicipio);
            if(funciono)
            {
                Console.WriteLine("Municipio Se Agrego  Exitosamente....");
                recargar(); 
            }
            else{
                Console.WriteLine("Error en el proceso");
                recargar();
            }
            

            

        }
        private static void eliminarMunicipio(){

           recargar();

            

        }

        private static void listarMunicipios()
        
        {

         List<Municipio> lstMunicipio= _repoMunicipio.ListarMunicipios1();

         foreach(Municipio mun in lstMunicipio)
         {

            Console.WriteLine( mun.id +" " +mun.Nombre );
         }   
        recargar();
        }
        private static void buscarMunicipio()
        {
            Municipio mun=null;
            Console.WriteLine("Ingrese el Id del municipio de desea buscar");
            mun= _repoMunicipio.BuscarMunicipio(int.Parse(Console.ReadLine()));
            if(mun != null)
            {
                Console.WriteLine(mun.id);
                Console.WriteLine(mun.Nombre);
                recargar();
            }
            Console.WriteLine("Municipio no registrado...");
            recargar();
        }

        private static void actualizarMunicipio()
        {
            Municipio mun= new Municipio();
            Console.WriteLine("Ingrese el codigo del municipio a modificar");
            mun.id=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre del municipio");
            mun.Nombre=Console.ReadLine();

            bool funciono= _repoMunicipio.ActualizarMunicipio(mun);

            if(funciono)
            {
                Console.WriteLine("Municipio actualizado con exito...");
                recargar();
            }
            else
            {
                Console.WriteLine("No fue posible realizar la modificacion");
                recargar();
            }
           
        }

       private static void recargar()

       {
           // Console.WriteLine("en implementacion ");
            Console.WriteLine("Presione una tecla para continuar...");          
            Console.ReadLine();
            Console.Clear();
            menu();
       }
    }
}    




