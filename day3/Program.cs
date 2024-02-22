int[] ints = [10, 45, 15, 39, 21, 26];

var id = 15;
var result = ints.Where(v=>v==id).FirstOrElseThrow($"el número {id} no existe en ints");
//var result = ints.Where(v=>v==id).FirstOrElseThrow();
Console.WriteLine(result);

class NotFoundException:Exception{
    public NotFoundException(string message):base(message){

    }
}
 public static class  OrThrow{
    public static TSource FirstOrElseThrow<TSource>(this IEnumerable<TSource> source, string? message=null){
        try{
            return source.First();
        }
        catch(InvalidOperationException ex){
            if(message!=null){
                throw new NotFoundException(message);    
            }
            throw new NotFoundException(ex.Message);
        }   
    }

    
 }