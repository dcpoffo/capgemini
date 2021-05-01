import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Pessoa } from 'src/app/models/Pessoa';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-update',
  templateUrl: './pessoa-update.component.html',
  styleUrls: ['./pessoa-update.component.scss']
})
export class PessoaUpdateComponent implements OnInit {

  pessoaForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
    sobrenome: new FormControl('', [Validators.required, Validators.minLength(3)])
  });

  //pessoa: Pessoa;
  pessoa: Pessoa = {
    nome: '',
    sobrenome: ''
  };

  constructor(
    private pessoaServico: PessoaService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.pessoaServico.getById(id).subscribe((pessoa) => {
      this.pessoa = pessoa;
    });
  }

  atualizar(): void {
    this.pessoaServico.put(this.pessoa).subscribe(() => {
      this.mensagemServico.showMessage('Cadastro atualizado com sucesso!');
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
