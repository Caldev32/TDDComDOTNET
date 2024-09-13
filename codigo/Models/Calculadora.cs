using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codigo.Models
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
           listahistorico = new List<string>;
           this.data = data;
        } 


        public int Somar(int val1,int val2){
            int res = val1 + val2;
            listahistorico.Insert(0, $"{va1} + {val2} = {res} - {data}")
            return res;
        }
        public int Subtrair(int val1,int val2){
            int res = val1 - val2;
            listahistorico.Insert(0, $"{va1} - {val2} = {res} - {data}")
            return res;
        }
        public int Dividir(int val1,int val2){
            int res = val1 / val2;
            listahistorico.Insert(0, $"{va1} / {val2} = {res} - {data}")
            return res;
        }
        public int Multiplicar(int val1,int val2){
            int res = val1 * val2;
            listahistorico.Insert(0, $"{va1} x {val2} = {res} - {data}")
            return res;
        }
        public List<string> VerHistorico(){
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count - 3)
            return listahistorico;
        }
    }
}