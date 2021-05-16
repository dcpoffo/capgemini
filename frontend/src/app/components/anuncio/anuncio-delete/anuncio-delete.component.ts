import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Anuncio } from 'src/app/models/Anuncio';
import { AnuncioService } from 'src/app/services/anuncio.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-anuncio-delete',
  templateUrl: './anuncio-delete.component.html',
  styleUrls: ['./anuncio-delete.component.scss']
})
export class AnuncioDeleteComponent implements OnInit {

  anuncio: Anuncio = {
    nome: '',
    clienteId: 0,
    dataInicio: null,
    dataTermino: null,
    investimentoDiario: 0,
    qtdDias: 0
  };

  constructor(
    private anuncioServico: AnuncioService,
    private router: Router,
    private route: ActivatedRoute,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.anuncioServico.getById(id).subscribe((anuncio) => {
      this.anuncio = anuncio;
    });
  }

  apagar(): void {
    this.anuncioServico.delete(this.anuncio.id).subscribe(() => {
      this.mensagemServico.showMessage('Anuncio excluído com sucesso!');
      this.router.navigate(['/anuncios']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/anuncios']);
  }

}
