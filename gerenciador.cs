/*********
* This Gist was created at CSharpPad.com
* To run this file, open http://csharppad.com/gist/4fe683c2f5d4664308b2
**********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

while (true)
{
    Console.WriteLine("Sistema de Despesas e Receitas");
    Console.WriteLine(" 1 - Registro de Receitas");
    Console.WriteLine(" 2 - Registro de Despesas");
    Console.WriteLine(" 3 - Cadastro de Categorias");
    Console.WriteLine(" 4 - Relatorios");
    Console.WriteLine(" 0 - Sair");
    
    int opcao = Convert.ToInt32(Console.ReadLine());
    
    if (opcao == 0){}
    break;
    
    switch(opcao)
    {
        case 1: GerenciadorFinaceiro.Domain.Receita();
        break;
        
        case 2: GerenciadorFinaceiro.Domain.Despesa();
        break;
        
        case 3: GerenciadorFinaceiro.Domain.Categoria();
        break;
        
        case 4: GerenciadorFinaceiro.Domain.Relatorio();
        break;
        
        default: Console.WriteLine("Opção digitada inválida.");
        break;
        
    }
}