import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { MinesweeperService, Row } from '../services/minesweeper.service';
import { NoNegativeNumbers } from '../validation/noNegativeNumbers.validation';

@Component({
  selector: 'app-minesweeper',
  templateUrl: './minesweeper.component.html',
  styleUrls: ['./minesweeper.component.css']
})

export class MineweeperComponent {
  public rows$: Observable<Row[]>;

  minesweeperForm = this.formBuilder.group({
    width: ['', [Validators.required, NoNegativeNumbers]],
    height: ['', [Validators.required, NoNegativeNumbers]],
  });

  constructor(private service: MinesweeperService, private formBuilder: FormBuilder) { }

  sumbit() {
    const width = this.minesweeperForm.get("width").value;
    const height = this.minesweeperForm.get("height").value;
    this.rows$ = this.service.getPanel(width, height);
  }

  checkBomb(cell) {
    if (cell.hasBomb) {
      alert("Oops - eine Bombe " + cell.location.row + "-" + cell.location.column);
      return;
    }

    alert("Keine Bombe " + cell.location.row + "-" + cell.location.column);
  }
}
