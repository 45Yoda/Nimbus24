using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nimbus24
{
    public class Proposta
    {
	string morada;
	string serviço;
	double preço;
	bool negociavel;
	string comentario;
    string prestador;//mail
    string cliente;//mail
    DateTime data;

    public Proposta()
        {
            morada = null;
            serviço = null;
            preço = 0.0;
            negociavel = false;
            comentario = null;
            prestador = null;
            cliente = null;
            data = default(DateTime);
        }

        public Proposta(string m,string s,float p,bool n,string c,string pr,string cl,DateTime d)
        {
            morada = m;
            serviço = s;
            preço = p;
            negociavel = n;
            comentario = c;
            prestador = pr;
            cliente = cl;
            data = d;
        }


        public Proposta(Proposta p)
        {
            morada = p.GetMorada();
            serviço = p.GetServiço();
            preço = p.GetPreço();
            negociavel = p.GetNegociavel();
            comentario = p.GetComentario();
            prestador = p.GetPrestador();
            cliente = p.GetCliente();
            data = p.GetData();
        }

        string GetMorada() { return morada;}
        string GetServiço() { return serviço; }
        double  GetPreço() { return preço; }
        bool GetNegociavel() { return negociavel; }
        string GetComentario() { return comentario; }
        string GetPrestador() { return prestador; }
        string GetCliente() { return cliente; }
        DateTime GetData() { return data; }

        void SetMorada(string m) { morada = m; }
        void SetServiço(string s) { serviço = s; }
        void SetPreço(double p) { preço = p; }
        void SetNegociavel(bool n) { negociavel = n; }
        void SetComentario(string c) { comentario=c; }
        void SetPrestador(string p) { prestador=p; }
        void SetCliente(string c) { cliente=c; }
       void SetData(DateTime d) { data=d; }

    }
}