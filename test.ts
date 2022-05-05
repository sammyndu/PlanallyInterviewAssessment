class MathClass{
 
    @subtract(1)
    addOne(number:number) {
        return number+1;
    }
 }
  
 console.log(new MathClass().addOne(2)) 


 function subtract(arg0: number): any {
    return  (
        target: Object,
        key: string | symbol,
        descriptor: PropertyDescriptor
      ) => {
          debugger;
        console.log(key);
        console.log(target);

        const childFunction = descriptor.value;
        descriptor.value = (...args: any[]) => {

            console.log(args[0])
            const result = childFunction.apply(globalThis, args);
            return result - arg0;
          };
          return descriptor;

      };
}


function multiply(arg0: number) {
    return  (
        target: Object,
        key: string | symbol,
        descriptor: PropertyDescriptor
      ) => {

 
        const childFunction = descriptor.value;
        descriptor.value = (...args: any[]) => {

            console.log(args[0])
            const result = childFunction.apply(globalThis, args);
            return result * arg0;
        }
          
    return descriptor;

      };
}
 