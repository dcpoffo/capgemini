import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Pessoa } from 'src/app/models/Pessoa';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-create',
  templateUrl: './pessoa-create.component.html',
  styleUrls: ['./pessoa-create.component.scss']
})
export class PessoaCreateComponent implements OnInit {

  pessoaForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
    sobrenome: new FormControl('', [Validators.required, Validators.minLength(3)])
  });

  pessoa: Pessoa = {
    nome: '',
    sobrenome: ''
  };

  constructor(
    private pessoaServico: PessoaService,
    private mensagemServico: MensagemService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  criarPessoa(): void {
    this.pessoaServico.post(this.pessoa).subscribe(() => {
      this.mensagemServico.showMessage('Pessoa cadastrada com sucesso!')
      this.router.navigate(['/pessoas']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/pessoas']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.pessoaForm.controls[controlName].hasError(errorName);
  }

}
