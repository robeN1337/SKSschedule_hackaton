import React from 'react';
import './RegisterC.css';

function registerComponent () {
    return (
      <div className="register_base">
          
          <div className="register">
            
              <h1 style={{textAlign: "center"}}>SKS Schedule</h1>

            <div className="register_triangle"></div>

            <h2 className="register_header">Зарегистрироваться</h2>

            <form className="register_container">
              
              <p><input type="email" placeholder="Email" /></p>
              <p><input type="Username" placeholder="Username" /></p>
              <p><input type="password" placeholder="Password" /></p>
              <p><input type="Potr.password" placeholder="Potr.Password" /></p>
              <p><input type="submit" value="Зарегистрироваться" /></p>
            </form>
          </div>

      </div>
          
    );
}


export default registerComponent;
