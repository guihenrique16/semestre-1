
Console.WriteLine(@$"
________________________
|  Escolha uma bebida  |
| 1. Coca cola         |
| 2. Pepsi             |
| 3. Guarana           |
| 4. Chá               |
| 5. Agua              |
------------------------
");
int bebidas = int.Parse(Console.ReadLine()!);

string gelo = "";

switch (bebidas)
{
    case 1:
        Console.WriteLine($"Gostaria de acrescentar gelo? sim/nao");
        gelo = Console.ReadLine()! .ToUpper();
        
        if ( gelo == "SIM" )
        {
            Console.WriteLine($"Seu pedido foi coca cola, com gelo.");
        } 
        else if ( gelo == "NAO" )
        {
            Console.WriteLine($"Seu pedido foi coca cola, sem gelo.");
            
        }
        else
        {
            Console.WriteLine($"Opção inválida");
            
        }
        break;
    
    case 2:
        Console.WriteLine($"Gostaria de acrescentar gelo? sim/nao");
        gelo = Console.ReadLine()! .ToUpper();
        
        if ( gelo == "SIM" )
        {
            Console.WriteLine($"Seu pedido foi Pepsi, com gelo.");
        }
        else if ( gelo == "NAO" )
        {
            Console.WriteLine($"Seu pedido foi Pepsi, sem gelo.");
            
        }
        else
        {
            Console.WriteLine($"Opção inválida");
            
        }
        break;
    
    case 3:
        Console.WriteLine($"Gostaria de acrescentar gelo? sim/nao");
        gelo = Console.ReadLine()! .ToUpper();
        
        if ( gelo == "SIM" )
        {
            Console.WriteLine($"Seu pedido foi Guaraná, com gelo.");
        }
        else if ( gelo == "NAO" )
        {
            Console.WriteLine($"Seu pedido foi Guaraná, sem gelo.");
            
        }
        else
        {
            Console.WriteLine($"Opção inválida");
            
        }
        break;
    
    case 4:
        Console.WriteLine($"Gostaria de acrescentar gelo? sim/nao");
        gelo = Console.ReadLine()! .ToUpper();
        
        if ( gelo == "SIM" )
        {
            Console.WriteLine($"Seu pedido foi chá, com gelo.");
        }
        else if ( gelo == "NAO" )
        {
            Console.WriteLine($"Seu pedido foi chá, sem gelo.");
            
        }
        else
        {
            Console.WriteLine($"Opção inválida");
            
        }
        break;
    
    case 5:
        Console.WriteLine($"Gostaria de acrescentar gelo? sim/nao");
        gelo = Console.ReadLine()! .ToUpper();
        
        if ( gelo == "SIM" )
        {
            Console.WriteLine($"Seu pedido foi agua, com gelo.");
        }
        else if ( gelo == "NAO" )
        {
            Console.WriteLine($"Seu pedido foi agua, sem gelo.");
            
        }
        else
        {
            Console.WriteLine($"Opção inválida");
            
        }
        break;
    
    default:
        break;
}

