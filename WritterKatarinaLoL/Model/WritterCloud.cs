using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class WritterCloud
    {
        //Inicia un "objeto" de la interfaz, de esta manera podremos acceder
        //a todos las clases que tengan implementada esta interfaz
        private IFormatable _formater;

        public WritterCloud(IFormatable formater)
        {
            _formater = formater;
        }

        //recibe un string con el nombre del archivo y escribe su extension y el contenido del archivo
        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}.{_formater.GetExtension()} : {_formater.GetContent()}");
        }
    }
}
