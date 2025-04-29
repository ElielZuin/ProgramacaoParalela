#include <stdio.h>
void funcao_a();
void funcao_b();
int cont_a=0,cont_b=0;
int tam=10000;
main()
{
  int ind;
  for (ind=0;ind<tam;ind++)
  {
  	funcao_a();
  	funcao_b();
  }
 printf ("\nTotal de chamada da funcao a  = %d",cont_a);
 printf ("\nTotal de chamada da funcao b  = %d",cont_b);
} 
//FUNÇÃO A
void funcao_a()
{
   cont_a++;
   //printf("\nAAAAAAAAAA");
}
//FUNÇÃO B
void funcao_b()
{
	cont_b++;
	//printf("\nBBBBBBBBBB");
}
	
