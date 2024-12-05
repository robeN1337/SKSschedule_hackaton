import React from 'react';
//import s from './LoginComponent.module.css';
import './LoginComponent.css';

function LoginComponent () {
    return (
      <div className="login_base">
          
          <div className="login">
            
              <h1 style={{textAlign: "center"}}>SKS Schedule</h1>

            <div className="login_triangle"></div>

            <h2 className="login_header">Войти</h2>

            <form className="login_container">
              
              <p><input type="email" placeholder="Email" /></p>
              <p><input type="password" placeholder="Password" /></p>
              <p><input type="submit" value="Войти" /></p>
            </form>
          </div>

      </div>
          
    );
}


export default LoginComponent;
