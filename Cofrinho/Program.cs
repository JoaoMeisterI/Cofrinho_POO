using System.Threading;
using Cofrinho;
using Cofrinho.Cofres;
using Cofrinho.Menus;
//
//
Console.OutputEncoding = System.Text.Encoding.UTF8;
//
Menu.MostraBemVindo("Seja bem vindo ao sistema de cofre");
//
Thread.Sleep(2000);
//
Cofre cofrinho = new Cofre();
bool rodarSistema = true;
//
while (rodarSistema == true)
{
    //
    string opcao = Menu.RetornaOpcao();
    //
    switch (opcao)
    {
        case "1":
            Menu menu1 = new MenuOpcao1();
            menu1.MostrarMenu(cofrinho);
            break;
        case "2":
            Menu menu2 = new MenuOpcao2();
            menu2.MostrarMenu(cofrinho);
            break;
        case "3":
            Menu menu3 = new MenuOpcao3();
            menu3.MostrarMenu(cofrinho);
            break;
        case "4":
            Menu menu4 = new MenuOpcao4();
            menu4.MostrarMenu(cofrinho);
            break;
        case "5":
            Console.WriteLine("$$ Encerrando Programa Cofrinho $$");
            rodarSistema = false;
            break;
        default:
            Console.WriteLine("Opção inválida, revise sua resposta!! \n");
            break;
    }
}
