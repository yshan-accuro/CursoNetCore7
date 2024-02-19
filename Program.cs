// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> list=[1,2,3,4];
foreach (var i in list.filter(x=>x%2==0)){
    Console.WriteLine(i);
}

static class enumExtension{
    public static IEnumerable<T> filter<T>(this IEnumerable<T> source, Func<T,bool> predicate){
        foreach(var v in source){
            if(predicate(v)){
                yield return v;
            }
        }
    }
}

class delagados{

    public delegate int operation(int x, int y);
    public delegate int operation2(int x, int y);
    static int Suma(int x, int y){
        return x+y;
    }
    static int Res(int x, int y){
        return x-y;
    }
    static int Mult(int x, int y){
        return x*y;
    }
    static int Div(int x, int y){
        return x/y;
    }

    List<operation> listOperacion = [Suma,Res,Mult,Div,(a,b)=>a+b];
}