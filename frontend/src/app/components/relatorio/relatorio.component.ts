import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Anuncio } from 'src/app/models/Anuncio';
import { AnuncioService } from 'src/app/services/anuncio.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.scss']
})
export class RelatorioComponent implements OnInit {

  anuncios: Anuncio[];
  displayedColumns = ['id', 'nome', 'cliente', 'dataInicio', 'dataTermino', 'qtdDias','investimentoDiario','totalInvestido','maxVisualizacoes','maxCliques','maxCompartilhamentos'];
  //displayedColumns = ['id', 'nome', 'cliente', 'dataInicio', 'dataTermino', 'qtdDias','investimentoDiario', 'totalInvestido', 'qtdMaxVis', 'qtdCliques'];

   form = new FormGroup({
    cliente: new FormControl(),
    dataI: new FormControl(),
    dataF: new FormControl(),
  });

  //campos para o ngModel, para ser passado para a função de busca
  public cliente: string;
  public dataI: Date = new Date(2000,0,1,0,0,0,0);
  public dataF: Date = new Date(2050,0,1,0,0,0,0);
  public resultado: number;

  constructor(
    private anuncioServico: AnuncioService,
    private mensagemServico: MensagemService,
    private router: Router
  ) {}

  ngOnInit() {
    this.dataI = new Date(2000,0,1,0,0,0,0);
    this.dataF = new Date(2050,0,1,0,0,0,0);
    this.anuncioServico.getAll().subscribe(anuncios => {
      this.anuncios = anuncios;
      console.log(anuncios);
    });
  }

  // pesquisarCliente(): void {
  //   console.log(this.cliente);
  //   //this.xxx => variaveis que vem do ngModel (campo de pesquisa)
  //   this.anuncioServico.GetAllAnunciosByNome(this.cliente).subscribe(anuncios => {
  //     this.anuncios = anuncios;
  //     this.router.navigate(['/relatorios']);
  //   })
  // }

  // pesquisarData(): void {
  //   console.log(this.dataI.toJSON());
  //   console.log(this.dataF.toJSON());

  //   this.anuncioServico.GetAllAnunciosByData(this.dataI,this.dataF).subscribe(anuncios => {
  //     this.anuncios = anuncios;
  //     this.router.navigate(['/relatorios']);
  //   })
  // }

  pesquisar(): void {
    if (this.cliente === "") {
      // console.log('cliente vazio');
      this.anuncioServico.GetAllAnunciosByData(this.dataI,this.dataF).subscribe(anuncios => {
        this.anuncios = anuncios;
        this.router.navigate(['/relatorios']);
    })
    }
    else {
      this.anuncioServico.GetAllAnunciosByPesquisa(this.cliente,this.dataI,this.dataF).subscribe(anuncios => {
        this.anuncios = anuncios;
        this.router.navigate(['/relatorios']);
      })
    }
  }

  limpar(): void {
    this.cliente = '';
    this.dataI = new Date(2000,0,1,0,0,0,0);
    this.dataF = new Date(2050,0,1,0,0,0,0);
    this.anuncioServico.getAll().subscribe(anuncios => {
      this.anuncios = anuncios;
      this.router.navigate(['/relatorios']);
    });
  }

  valorTotalInvestido(qtdDias,valorDiario){
    const retorno = qtdDias * valorDiario;
    return retorno;
  }

  maximoCliques(valor,qtdDias){
    const retorno =  Math.round(30*qtdDias);
    return retorno;
  }

  calcularQtdMaxVisualizacoes(valor){
    const quantidadeAlcance = valor * 30;
    const quantidadeCliques = quantidadeAlcance * 0.12;
    const quantidadeCompartilhamentos = quantidadeCliques * 0.3;
    const quantidadeNovosCompartilhamentos = quantidadeCompartilhamentos * 40;
    const maximoCompartilhamentos = Math.round((quantidadeNovosCompartilhamentos + 160));
    return maximoCompartilhamentos;
  }

  calcularQtdMaxCompartilhamento(valor,qtdeDias){
    const quantidadeAlcance = valor * 30;
    const quantidadeCliques = quantidadeAlcance * 0.12;
    const quantidadeCompartilhamentos = quantidadeCliques * 0.3;
    const quantidadeNovosCompartilhamentos = quantidadeCompartilhamentos * 40;
    const maximoCompartilhamentos = Math.round((quantidadeNovosCompartilhamentos + 160)*qtdeDias);
    return maximoCompartilhamentos;
  }
}
