
using _3_OO;

UnidadeSaude us1 = new UnidadeSaude("Unidade São José", "USJ");

//milhares de linhas de código depois

us1.Responsavel.Nome = "Alexandre de Oliveira Zamberlan";
us1.Responsavel.Tipo = "enfermEiro";
us1.Responsavel.RegistroConselho = "TEC123";



Paciente pac1 = new Paciente("Leandro Lazarin", "9884848848", DateOnly.Parse("08/09/1974"), "laza@ufn.edu.br");

ProfissionalSaude resp1 = new ProfissionalSaude("Daniela Rodrigues", "Enfermeiro", "Enf1231");


Triagem t1 = new Triagem(resp1, pac1, 88, 1.88, 122, 38, "amarelo");






