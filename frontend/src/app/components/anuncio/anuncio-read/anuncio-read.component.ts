import { Component, OnInit } from '@angular/core';
import { Anuncio } from 'src/app/models/Anuncio';
import { AnuncioService } from 'src/app/services/anuncio.service';

@Component({
  selector: 'app-anuncio-read',
  templateUrl: './anuncio-read.component.html',
  styleUrls: ['./anuncio-read.component.scss']
})
export class AnuncioReadComponent implements OnInit {

  anuncios: Anuncio[];
  displayedColumns = ['id', 'nome', 'cliente', 'dataInicio', 'dataTermino', 'qtdDias', 'investimentoDiario','acoes'];
  //displayedColumns = ['id', 'nome', 'dataInicio', 'dataTermino', 'investimentoDiario','acoes'];

  constructor(
    private anuncioServico: AnuncioService
  ) { }

  ngOnInit() {
    this.anuncioServico.getAll().subscribe(anuncios => {
      this.anuncios = anuncios;
      console.log(anuncios);
    });
  }

}
