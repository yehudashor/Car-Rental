import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NavigtionComponent } from './navigtion/navigtion.component';
import { AppRoutingModule } from '../app-routing.module';
import { CoreRoutingModule } from './core-routing.module';

const modules = [CoreRoutingModule]

@NgModule({
  declarations: [NavigtionComponent],
  imports: [modules],
  exports: [modules, ],
  providers: [],
  bootstrap: [],
})
export class CoreModule {}
