using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;

/***********************************************
* 
*           ReflectionEmit
*          
*        1. 코드 요소 동적 생성
*        2. Emit을 이용한 코드 실행
* 
* *********************************************/
namespace ReflectionEmit.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;

            /* 코드 요소 동적 생성 */
            AssemblyBuilder newAssembly =
                        AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("ArithmethicAssembly"), AssemblyBuilderAccess.Run); // 1. 에셈블리 생성 

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("ArithmethicModule"); // 2. 모듈 생성

            TypeBuilder newType = newModule.DefineType("SortClass"); // 3. 클래스 생성

            MethodBuilder newMethod_add = newType.DefineMethod("AddFunc", MethodAttributes.Public, typeof(int), new Type[0]);
            MethodBuilder newMethod_sub = newType.DefineMethod("SubFunc", MethodAttributes.Public, typeof(int), new Type[0]);
            MethodBuilder newMethod_mul = newType.DefineMethod("MulFunc", MethodAttributes.Public, typeof(int), new Type[0]);
            MethodBuilder newMethod_div = newType.DefineMethod("DivFunc", MethodAttributes.Public, typeof(float), new Type[0]); //4. 메소드 생성

            ILGenerator generator_add = newMethod_add.GetILGenerator();
            ILGenerator generator_sub = newMethod_sub.GetILGenerator();
            ILGenerator generator_mul = newMethod_mul.GetILGenerator();
            ILGenerator generator_div = newMethod_div.GetILGenerator(); // 5. 코드 작성 

            /* 2. Emit을 이용한 코드 실행 */
            generator_add.Emit(OpCodes.Ldc_I4, num1); //num1을 스택에 푸쉬
            generator_add.Emit(OpCodes.Ldc_I4, num2); //num2를 스택에 푸쉬
            generator_add.Emit(OpCodes.Add); //스택에 있는 값을 더한다.

            generator_sub.Emit(OpCodes.Ldc_I4, num1);
            generator_sub.Emit(OpCodes.Ldc_I4, num2);
            generator_sub.Emit(OpCodes.Sub); //스택에 있는 값을 뺀다.

            generator_mul.Emit(OpCodes.Ldc_I4, num1);
            generator_mul.Emit(OpCodes.Ldc_I4, num2);
            generator_mul.Emit(OpCodes.Mul); //스택에 있는 값을 곱한다.

            generator_div.Emit(OpCodes.Ldc_I4, num1);
            if (num2 != 0)
                generator_div.Emit(OpCodes.Ldc_I4, num2);
            else
                generator_div.Emit(OpCodes.Ldc_I4, 1);
            generator_div.Emit(OpCodes.Div); //스택에 있는 값을 나눈다.


            generator_add.Emit(OpCodes.Ret); //스택에 있는 결과값을 꺼냄
            generator_sub.Emit(OpCodes.Ret);
            generator_mul.Emit(OpCodes.Ret);
            generator_div.Emit(OpCodes.Ret);



            newType.CreateType();

            object SortClass = Activator.CreateInstance(newType); //돋적으로 생성한 클래스의 인스턴스 생성

            MethodInfo AddFunc = SortClass.GetType().GetMethod("AddFunc"); //메소드 가져오기
            MethodInfo SubFunc = SortClass.GetType().GetMethod("SubFunc");
            MethodInfo MulFunc = SortClass.GetType().GetMethod("MulFunc");
            MethodInfo DivFunc = SortClass.GetType().GetMethod("DivFunc");

            /* 함수 실행 부분 */
            Console.WriteLine("=== Add Function() ===");
            Console.WriteLine(num1 + " + " + num2 + " = " + AddFunc.Invoke(SortClass, null));
            Console.WriteLine();

            Console.WriteLine("=== Sub Function() ===");
            Console.WriteLine(num1 + " - " + num2 + " = " + SubFunc.Invoke(SortClass, null));
            Console.WriteLine();

            Console.WriteLine("=== Mul Function() ===");
            Console.WriteLine(num1 + " * " + num2 + " = " + MulFunc.Invoke(SortClass, null));
            Console.WriteLine();

            Console.WriteLine("=== Div Function() ===");
            Console.WriteLine(num1 + " / " + num2 + " = " + DivFunc.Invoke(SortClass, null));
            Console.WriteLine();
        }
    }
}
