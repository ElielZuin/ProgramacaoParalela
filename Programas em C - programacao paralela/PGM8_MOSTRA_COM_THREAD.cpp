#include <stdio.h>
#include <windows.h> // biblioteca para a criação de thread 
void funcao_a();
void funcao_b();
void funcao_c();
void funcao_d();
int cont_a=0,cont_b=0,cont_c=0,cont_d=0;
int tam=5;
main()
{
  int ind,controle; // variável controle utilizada no comando para criar thread. Pode ser outro nome
  DWORD dwThreadid;
  HANDLE fun_th[4];
  for (ind=0;ind<tam;ind++)
  {
  	//NULL - parâmetro de segurança que quer dize sem password(senha).
  	// 0 - Tamanho da área da thread. Zero quer dizer que não tem limite. Quanto precisar de memória irá utilizar.
    // funcao_a - Thread a ser criada e chamada.
    // (LPVOID) - sem retôrno de parâmetro(valor).
    // &controle - Exige que se passemum parâmetro ou seja uma variável.
    // 0 - Tempo para start(chamar a thread). Zero significa imediatamente.
    // dwThreadid - id(identificação) da thread que será criada. Serve para saber se a thread acabou.
    fun_th[0] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&funcao_a,(LPVOID)&controle,0,&dwThreadid);
  	fun_th[1] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&funcao_b,(LPVOID)&controle,0,&dwThreadid);
  	fun_th[2] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&funcao_c,(LPVOID)&controle,0,&dwThreadid);
  	fun_th[3] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&funcao_d,(LPVOID)&controle,0,&dwThreadid);
  }
 WaitForMultipleObjects(4,fun_th,TRUE,INFINITE);
 printf ("\nTotal de chamada da funcao a  = %d",cont_a);
 printf ("\nTotal de chamada da funcao b  = %d",cont_b);
 printf ("\nTotal de chamada da funcao c  = %d",cont_c);
 printf ("\nTotal de chamada da funcao d  = %d",cont_d);
} 
//FUNÇÃO A
void funcao_a()
{
   cont_a++;
   printf("\nAAAAAAAAAA");
}
//FUNÇÃO B
void funcao_b()
{
	cont_b++;
	printf("\nBBBBBBBBBB");
}
//FUNÇÃO C
void funcao_c()
{
	cont_c++;
	printf("\nCCCCCCCCCC");
}
//FUNÇÃO d
void funcao_d()
{
	cont_d++;
	printf("\nDDDDDDDDDD");
}

