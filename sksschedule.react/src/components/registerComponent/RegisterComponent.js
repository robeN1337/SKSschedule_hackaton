import React from 'react';
import './RegisterComponent.css';

function RegisterComponent () {
    return (
    
      <div className="register" >
        <div className="register_triangle"></div>
      
        <h2 className="register-header">Регистрация</h2>
      
        <form className="register-container">
          <p><input type="email" placeholder="Email" /></p>
          <p><input type="username" placeholder="Username" /></p>
          <p><input type="password" placeholder="Password" /></p>
          <p><input type="password" placeholder="Potr.Password" /></p>
          <p><input type="submit" value="Register" /></p>
        </form>
      </div>
          
    );
}


export default RegisterComponent;
