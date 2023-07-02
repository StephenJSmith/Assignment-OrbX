import { Component, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from '../../models/product';
import { ProductsService } from '../../services/products.service';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.scss']
})
export class ProductsListComponent implements OnDestroy {
  simulator: string = '';
  products: IProduct[] = [];

  private subscription: Subscription |null = null;
  private sortField: string = 'currentPrice';
  private sortOrder: string = 'desc';

  constructor(private productService: ProductsService) {}

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  onSearch(): void {
    if (!this.simulator) {
      this.products = [];

      return;
    };

    this.subscription = this.productService
      .getProductsList(this.simulator, this.sortField, this.sortOrder)
      .subscribe((products: IProduct[]) => this.products = products);
  }

  spaceProductSimulators(simulators: string[]): string {
    return simulators.join(', ');
  }
}
