using System;
using System.Collections.Generic;
using System.Text;
using WritterJavi.Interface;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Factory : IFactory
    {
        //inicia un diccionario
        private readonly Dictionary<string, IFormatable> _formatList;

        //constructor de Factory, pasandole un diccionario e igualamos (como el .this)
        public Factory(Dictionary<string, IFormatable> formatersList)
        {
            _formatList = formatersList;
        }

        //Método para devolver un objeto Writter iniciado,
        //el string "formater" será el que defina el tipo de archivo del diccionario
        public IWritter GetWritter(string formater)
        {
            return new Writter(_formatList[formater]);
        }

    }
}
