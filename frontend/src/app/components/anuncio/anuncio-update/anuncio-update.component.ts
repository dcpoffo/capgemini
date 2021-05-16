import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Anuncio } from 'src/app/models/Anuncio';
import { Cliente } from 'src/app/models/Cliente';
import { AnuncioService } from 'src/app/services/anuncio.service';
import { ClienteService } from 'src/app/services/Cliente.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-anuncio-update',
  templateUrl: './anuncio-update.component.html',
  styleUrls: ['./anuncio-update.component.scss']
})
export class AnuncioUpdateComponent implements OnInit {

  form = new FormGroup({
    cliente: new FormControl('', [Validators.required]),
    nome: new FormControl('', [Validators.required,Validators.minLength(3),Validators.maxLength(20)]),
    dataInicio: new FormControl('', [Validators.required]),
    dataTermino: new FormControl('', [Validators.required]),
    investimento: new FormControl('', [Validators.required,Validators.min(1)])
  });


  anuncio: Anuncio = {
    id: 0,
    nome: '',
    clienteId: 0,
    dataInicio: null,
    dataTermino: null,
    investimentoDiario: 1
  };

  clientes: Cliente[];

  constructor(
    private anuncioServico: AnuncioService,
    private clienteServico: ClienteService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.carregarPessoas();
    const id = +this.route.snapshot.paramMap.get('id');
    this.anuncioServico.getById(id).subscribe((anuncio) => {
      this.anuncio = anuncio;
    });
  }

  carregarPessoas(): void {
    this.clienteServico.getAll().subscribe(cli => {
      this.clientes = cli;
    });
  }

  atualizar(): void {
    if (this.anuncio.dataTermino <= this.anuncio.dataInicio) {
      this.mensagemServico.showMessage('A Data Término não pode ser menor ou igual a Data Início',true);
    }
    else {
      this.anuncioServico.put(this.anuncio).subscribe(() => {
        this.mensagemServico.showMessage('Anuncio atualizado com sucesso!');
        this.router.navigate(['/anuncios']);
      });
    }
  }

  cancelar(): void {
    this.router.navigate(['/anuncios']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.form.controls[controlName].hasError(errorName);
  }

}
