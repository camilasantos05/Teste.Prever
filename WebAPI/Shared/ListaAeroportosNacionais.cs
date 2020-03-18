using System.Collections.Generic;
using System.Linq;
using static WebAPI.Shared.ListaGenerica;

namespace WebAPI.Shared
{
    public class ListaAeroportosNacionais : StringString
    {
        public ListaAeroportosNacionais()
        { }

        public static List<ListaAeroportosNacionais> Lista
        {
            get
            {
                List<ListaAeroportosNacionais> lista = new List<ListaAeroportosNacionais>();

                lista.Add(tcSbbr);
                lista.Add(tcSbsp);
                lista.Add(tcSbgl);
                lista.Add(tcSbsv);
                lista.Add(tcSbfl);
                lista.Add(tcSbpa);
                lista.Add(tcSbkp);
                lista.Add(tcSbrf);
                lista.Add(tcSbct);
                lista.Add(tcSbbe);
                lista.Add(tcSbvt);
                lista.Add(tcSbrj);
                lista.Add(tcSbcy);
                lista.Add(tcSbcg);
                lista.Add(tcSbfz);
                lista.Add(tcSbmq);
                lista.Add(tcSbmg);
                lista.Add(tcSbgo);
                lista.Add(tcSbnf);
                lista.Add(tcSbeg);
                lista.Add(tcSbnt);
                lista.Add(tcSbps);
                lista.Add(tcSbmo);
                lista.Add(tcSsps);
                lista.Add(tcSbsl);
                lista.Add(tcSbgr);
                lista.Add(tcSblo);
                lista.Add(tcSbpv);
                lista.Add(tcSbrb);
                lista.Add(tcSbjv);
                lista.Add(tcSbul);
                lista.Add(tcSbcx);
                lista.Add(tcSbfi);
                lista.Add(tcSbte);
                lista.Add(tcSbar);
                lista.Add(tcSbjp);
                lista.Add(tcSbpl);
                lista.Add(tcSbcf);
                lista.Add(tcSbbv);
                lista.Add(tcSbkg);
                lista.Add(tcSbsn);
                lista.Add(tcSbil);
                lista.Add(tcSbju);
                lista.Add(tcSbiz);
                lista.Add(tcSbch);
                lista.Add(tcSbma);
                lista.Add(tcSbcz);
                lista.Add(tcSbdn);
                lista.Add(tcSbcb);
                lista.Add(tcSbfn);
                lista.Add(tcSjtc);
                lista.Add(tcSbmk);

                return lista.ToList();
            }
        }

        public static ListaAeroportosNacionais ObterPorID(string id)
        {
            var opcao = Lista.Where(x => x.Id == id).FirstOrDefault();
            return opcao;
        }

        public static ListaAeroportosNacionais ObterPorIDDefault(string id)
        {
            var opcao = Lista.Where(x => x.Id == id).FirstOrDefault();
            return opcao;
        }

        public static ListaAeroportosNacionais tcSbbr
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBBR",
                    Descricao = "Aeroporto Internacional de Brasília / Presidente Jucelino Kubitschek"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbsp
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBSP",
                    Descricao = "Aeroporto Internacional de São Paulo / Congonhas"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbgl
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBGL",
                    Descricao = "Aeroporto Internacional do Rio de Janeiro / Galeão-Antônio Carlos Jobim"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbsv
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBSV",
                    Descricao = "Aeroporto Internacional de Salvador / Deputado Luis Eduardo Magalhães"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbfl
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBFL",
                    Descricao = "Aeroporto Internacional de Florianópolis / Hercílio Luz"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbpa
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBPA",
                    Descricao = "Aeroporto Internacional de Porto Alegre / Salgado Filho"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbkp
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBKP",
                    Descricao = "Aeroporto Internacional de Viracopos / Campinas"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbrf
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBRF",
                    Descricao = "Aeroporto Internacional do Recife/ Guararapes – Gilberto Freyre"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbct
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCT",
                    Descricao = "Aeroporto Internacional de Curitiba / Afonso Pena"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbbe
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBBE",
                    Descricao = "Aeroporto Internacional de Belém / Val de Cans"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbvt
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBVT",
                    Descricao = "Aeroporto de Vitória – Eurico de Aguiar Salles"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbrj
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBRJ",
                    Descricao = "Aerorporto Santos Dumont"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcy
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCY",
                    Descricao = "Aeroporto Internacional de Cuiabá / Marechal Rondon"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcg
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCG",
                    Descricao = "Aeroporto Internacional de Campo Grande"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbfz
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBFZ",
                    Descricao = "Aeroporto Internacional de Fortaleza / Pinto Martins"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbmq
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBMQ",
                    Descricao = "Aeroporto Internacional de Macapá"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbmg
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBMG",
                    Descricao = "Aeroporto Regional de Maringá / Silvio Name Junior"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbgo
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBGO",
                    Descricao = "Aeroporto de Goiânia / Santa Genoveva"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbnf
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBNF",
                    Descricao = "Aeroporto Internacional de Navegantes / Ministro Victor Konder"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbeg
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBEG",
                    Descricao = "Aeroporto Internacional de Manaus / Eduardo Gomes"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbnt
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBNT",
                    Descricao = "Aeroporto Internacional de Natal / Augusto Severo"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbps
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBPS",
                    Descricao = "Aeroporto Internacional de Porto Seguro"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbmo
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBMO",
                    Descricao = "Aeroporto de Maceió / Zumbi dos Palmares"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSsps
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SSPS",
                    Descricao = "Aeroporto de Palmas/Brigadeiro Lysias Rodrigues"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbsl
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBSL",
                    Descricao = "Aeroporto Internacional de São Luís / Marechal Cunha Machado"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbgr
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBGR",
                    Descricao = "Aeroporto Internacional de São Paulo/Guarulhos-Governador André Franco Motoro"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSblo
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBLO",
                    Descricao = "Aeroporto de Londrina / Governador José Richa"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbpv
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBPV",
                    Descricao = "Aeroporto Internacional de Porto Velho / Governador Jorge Teixeira de Oliveira"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbrb
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBRB",
                    Descricao = "Aeroporto Internacional de Rio Branco / Plácido de Castro"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbjv
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBJV",
                    Descricao = "Aeroporto de Joinville / Lauro Carneiro de Loyola"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbul
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBUL",
                    Descricao = "Aeroporto de Uberlândia / Ten. Cel. Av. César Bombonato"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcx
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCX",
                    Descricao = "Aeroporto Regional de Caxias do Sul / Hugo Cantergiani"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbfi
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBFI",
                    Descricao = "Aeroporto Internacional de Foz do Iguaçu"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbte
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBTE",
                    Descricao = "Aeroporto de Teresina – Senador Petrônio Portella"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbar
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBAR",
                    Descricao = "Aeroporto Internacional de Aracaju / Santa Maria"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbjp
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBJP",
                    Descricao = "Aeroporto Internacional de João Pessoa / Presidente Castro Pinto"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbpl
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBPL",
                    Descricao = "Aeroporto de Petrolina / Senador Nilo Coelho"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcf
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCF",
                    Descricao = "Aeroporto Internacional de Minas Gerais / Confins – Tancredo Neves"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbbv
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBBV",
                    Descricao = "Aeroporto Internacional de Boa Vista / Atlas Brasil Cantanhede"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbkg
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBKG",
                    Descricao = "Aeroporto de Campina Grande / Presidente João Suassuna"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbsn
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBSN",
                    Descricao = "Aeroporto de Santarém / Maestro Wilson Fonseca"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbil
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBIL",
                    Descricao = "Aeroporto de Ilhéus/Bahia-Jorge Amado"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbju
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBJU",
                    Descricao = "Aeroporto de Juazeiro do Norte – Orlando Bezerra"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbiz
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBIZ",
                    Descricao = "Aeroporto de Imperatriz – Prefeito Renato Moreira"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbch
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCH",
                    Descricao = "Aeroporto de Chapecó – Serafin Enoss Bertaso"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbma
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBMA",
                    Descricao = "Aeroporto de Marabá"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcz
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCZ",
                    Descricao = "Aeroporto Internacional de Cruzeiro do Sul"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbdn
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBDN",
                    Descricao = "Aeroporto Estadual de Presidente Prudente"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbcb
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBCB",
                    Descricao = "Aeroporto Internacional de Cabo Frio"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbfn
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBFN",
                    Descricao = "Aeroporto de Fernando de Noronha"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSjtc
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SJTC",
                    Descricao = "Aeroporto Estadual de Bauru/Arealva"
                };
            }
            private set { }
        }

        public static ListaAeroportosNacionais tcSbmk
        {
            get
            {
                return new ListaAeroportosNacionais
                {
                    Id = "SBMK",
                    Descricao = "Aeroporto de Montes Claros/Mário Ribeiro"
                };
            }
            private set { }
        }

        public static string SBBR { get { return tcSbbr.Id; } private set { } }
        public static string SBSP { get { return tcSbsp.Id; } private set { } }
        public static string SBGL { get { return tcSbgl.Id; } private set { } }
        public static string SBSV { get { return tcSbsv.Id; } private set { } }
        public static string SBFL { get { return tcSbfl.Id; } private set { } }
        public static string SBPA { get { return tcSbpa.Id; } private set { } }
        public static string SBKP { get { return tcSbkp.Id; } private set { } }
        public static string SBRF { get { return tcSbrf.Id; } private set { } }
        public static string SBCT { get { return tcSbct.Id; } private set { } }
        public static string SBBE { get { return tcSbbe.Id; } private set { } }
        public static string SBVT { get { return tcSbvt.Id; } private set { } }
        public static string SBRJ { get { return tcSbrj.Id; } private set { } }
        public static string SBCY { get { return tcSbcy.Id; } private set { } }
        public static string SBCG { get { return tcSbcg.Id; } private set { } }
        public static string SBFZ { get { return tcSbfz.Id; } private set { } }
        public static string SBMQ { get { return tcSbmq.Id; } private set { } }
        public static string SBMG { get { return tcSbmg.Id; } private set { } }
        public static string SBGO { get { return tcSbgo.Id; } private set { } }
        public static string SBNF { get { return tcSbnf.Id; } private set { } }
        public static string SBEG { get { return tcSbeg.Id; } private set { } }
        public static string SBNT { get { return tcSbnt.Id; } private set { } }
        public static string SBPS { get { return tcSbps.Id; } private set { } }
        public static string SBMO { get { return tcSbmo.Id; } private set { } }
        public static string SSPS { get { return tcSsps.Id; } private set { } }
        public static string SBSL { get { return tcSbsl.Id; } private set { } }
        public static string SBGR { get { return tcSbgr.Id; } private set { } }
        public static string SBLO { get { return tcSblo.Id; } private set { } }
        public static string SBPV { get { return tcSbpv.Id; } private set { } }
        public static string SBRB { get { return tcSbrb.Id; } private set { } }
        public static string SBJV { get { return tcSbjv.Id; } private set { } }
        public static string SBUL { get { return tcSbul.Id; } private set { } }
        public static string SBCX { get { return tcSbcx.Id; } private set { } }
        public static string SBFI { get { return tcSbfi.Id; } private set { } }
        public static string SBTE { get { return tcSbte.Id; } private set { } }
        public static string SBAR { get { return tcSbar.Id; } private set { } }
        public static string SBJP { get { return tcSbjp.Id; } private set { } }
        public static string SBPL { get { return tcSbpl.Id; } private set { } }
        public static string SBCF { get { return tcSbcf.Id; } private set { } }
        public static string SBBV { get { return tcSbbv.Id; } private set { } }
        public static string SBKG { get { return tcSbkg.Id; } private set { } }
        public static string SBSN { get { return tcSbsn.Id; } private set { } }
        public static string SBIL { get { return tcSbil.Id; } private set { } }
        public static string SBJU { get { return tcSbju.Id; } private set { } }
        public static string SBIZ { get { return tcSbiz.Id; } private set { } }
        public static string SBCH { get { return tcSbch.Id; } private set { } }
        public static string SBMA { get { return tcSbma.Id; } private set { } }
        public static string SBCZ { get { return tcSbcz.Id; } private set { } }
        public static string SBDN { get { return tcSbdn.Id; } private set { } }
        public static string SBCB { get { return tcSbcb.Id; } private set { } }
        public static string SBFN { get { return tcSbfn.Id; } private set { } }
        public static string SJTC { get { return tcSjtc.Id; } private set { } }
        public static string SBMK { get { return tcSbmk.Id; } private set { } }
    }
}
