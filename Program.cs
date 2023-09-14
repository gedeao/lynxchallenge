using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AverageCalculator
{
    public class NotesControl
    {
        private double _n1 = -1;
        private double _n2 = -1;
        private double _n3 = -1;
        public NotesControl()
        {
            //return newControl;
        }
        public double AverageCalculator()
        {
            Double _response = (this._n1 * 2 + this._n2 * 3 + this._n3 * 5) / 10;
            return _response;
        }
        public void insertNote(string Key, double value)
        {
            switch (Key)
            {
                case "A":
                    this._n1 = value;
                    Console.WriteLine($"Inserido valor: {this._n1} com sucesso!");
                    break;
                case "B":
                    this._n2 = value;
                    Console.WriteLine($"Inserido valor: {this._n2} com sucesso!");
                    break;
                case "C":
                    this._n3 = value;
                    Console.WriteLine($"Inserido valor: {this._n3} com sucesso!");
                    break;
            }
            return;
        }
        public bool checkNoteNull(string Key)
        {
            switch (Key)
            {
                case "A":
                    return this._n1 == -1 ? true : false;
                    break;
                case "B":
                    return this._n2 == -1 ? true : false;
                    break;
                case "C":
                    return this._n3 == -1 ? true : false;
                    break;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // flag para manter janela aberta e calcular varias medias
            String stay = "N";

            // para utilizar . ao inves de vigula conforme especificacao
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            Console.WriteLine("Olá! Bem-Vindo ao sistema de média de notas Lynx");
            //enquanto nao S programa permanecera em execucao
            while (stay != "S")
            {
                Console.WriteLine("Olá! Insira a primeira nota(utilize apenas uma casa decimal)");
                var _noteControl = new NotesControl();

                while (_noteControl.checkNoteNull("A") == true)
                {
                    if (double.TryParse(Console.ReadLine(), out double doubleValue))
                    {
                        var _doubleValue = Math.Round(doubleValue, 1);
                        if (_doubleValue > 0f && _doubleValue <= 10.0f)
                            _noteControl.insertNote("A", _doubleValue);
                        else
                        {
                            Console.WriteLine($"As notas devem estar em um intervalo de 0 a 10");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor Invalido digite conforme exemplo: 9.5");
                    }
                }

                Console.WriteLine("Olá! Insira a segunda nota(utilize apenas uma casa decimal)");
                while (_noteControl.checkNoteNull("B") == true)
                {
                    if (double.TryParse(Console.ReadLine(), out double doubleValue2))
                    {
                        var _doubleValue2 = Math.Round(doubleValue2, 1);
                        if (_doubleValue2 > 0f && _doubleValue2 <= 10.0f)
                            _noteControl.insertNote("B", _doubleValue2);
                        else
                        {
                            Console.WriteLine($"As notas devem estar em um intervalo de 0 a 10");
                        }
                        //Console.WriteLine($"Parsed value: {doubleValue}");
                    }
                    else
                    {
                        Console.WriteLine("Olá! Insira a segunda nota(utilize apenas uma casa decimal)");
                    }
                }
                Console.WriteLine("Olá! Insira a terceira nota(utilize apenas uma casa decimal)");
                while (_noteControl.checkNoteNull("C") == true)
                {
                    if (double.TryParse(Console.ReadLine(), out double doubleValue3))
                    {
                        var _doubleValue3 = Math.Round(doubleValue3, 1);
                        if (_doubleValue3 > 0f && _doubleValue3 <= 10.0f)
                            _noteControl.insertNote("C", _doubleValue3);
                        else
                        {
                            Console.WriteLine($"As notas devem estar em um intervalo de 0 a 10");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor Invalido digite conforme exemplo: 9.5");
                    }
                }
                Console.WriteLine($"MEDIA = {Math.Round(_noteControl.AverageCalculator(),1)}");
                Console.WriteLine($"INSIRA S Para SAIR ou Click Enter Para Continuar");
                stay = Console.ReadLine();
            }
        }
    }
}