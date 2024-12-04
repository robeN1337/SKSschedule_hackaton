import React from 'react';
//import s from './LoginComponent.module.css';

function LoginComponent () {
    return (
      <div className="login_base">
          
          <div className="login">
            
              <h1>SKS Schedule</h1>

            <div className="login_triangle"></div>

            <h2 className="login_header">Log in</h2>

            <form className="login_container">
              
              <p><input type="email" placeholder="Email" /></p>
              <p><input type="password" placeholder="Password" /></p>
              <p><input type="submit" value="Log in" /></p>
            </form>
          </div>

      </div>
          
    );
}


export default LoginComponent;
