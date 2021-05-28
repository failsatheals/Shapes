 abstract class Shape
 {
     public Shape(string name){
         this.Name = name;
     }
     public abstract double Area {get;}
     public string Name {get; set;}
     public override string ToString(){
         return $"The area of {Name} is {Area} ";
     }

 }