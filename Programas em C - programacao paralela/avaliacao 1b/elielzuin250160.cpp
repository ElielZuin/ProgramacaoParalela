//ELIEL DA SILVA ANDRADE ZUIN 250160
#include <stdio.h>
#include <windows.h>

void corretor();	//calculo das despesas do corretor
void cartorio();	//calculo das despesas do cartorio


float preco_venda, preco_final;
float parte_corretor,parte_cartorio;

main()
{	
	int ind,controle; // variável controle utilizada no comando para criar thread. Pode ser outro nome
 	DWORD dwThreadid;
	HANDLE fun_th[2];
	
	printf("\nInforme o preco de venda do imovel: ");
	scanf("%f",&preco_venda);
	
	fun_th[0] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&corretor,(LPVOID)&controle,0,&dwThreadid);
  	fun_th[1] = CreateThread(NULL,0,(LPTHREAD_START_ROUTINE)&cartorio,(LPVOID)&controle,0,&dwThreadid);
	
	WaitForMultipleObjects(2,fun_th,TRUE,INFINITE);
 	
 	preco_final = preco_venda + parte_corretor + parte_cartorio;
	
	printf("\nO valor de venda do imovel e: %.2f",preco_venda);
	printf("\nA porcentagem do corretor e: %.2f",parte_corretor);
	printf("\nAs despesas do cartorio sao: %.2f",parte_cartorio);
	printf("\nO preco final do imovel ficou em: R$ %.2f",preco_final);
}

//funcao que calcula a % do corretor
void corretor()
{	
	if (preco_venda <= 50000){
		parte_corretor = preco_venda
		 * 0.06;
	}
	else if (preco_venda > 50000 && preco_venda <= 150000){
		parte_corretor = preco_venda * 0.05;
	}
	else{
		parte_corretor = preco_venda * 0.04;
	}
}

// funcao que calcula as despesas com cartorio
void cartorio()
{	
	if (preco_venda <= 40000){
		parte_cartorio = preco_venda * 0.04;
	}
	else if (preco_venda > 40000 && preco_venda <= 100000){
		parte_cartorio = preco_venda * 0.03;
	}
	else{
		parte_cartorio = preco_venda * 0.01;
	}
}


//ELIEL DA SILVA ANDRADE ZUIN 250160
//ELIEL DA SILVA ANDRADE ZUIN 250160
//ELIEL DA SILVA ANDRADE ZUIN 250160
//ELIEL DA SILVA ANDRADE ZUIN 250160
//ELIEL DA SILVA ANDRADE ZUIN 250160
//ELIEL DA SILVA ANDRADE ZUIN 250160

