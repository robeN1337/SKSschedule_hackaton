import React from "react";
import { Link } from "react-router-dom";
import './Header.css';

const Header = () => {
  return (
    <header className="header">
      <div className="logo">
        <img src="../../../logomain.png" alt="Logo" className="logo-image" />
        College Schedule
      </div>
      <nav>
        <ul className="nav-links">
          <li ><Link to="/">Главная</Link></li>
          <li><Link to="/schedule">Расписание</Link></li>
          <li><Link to="Register">Регистрация</Link></li>
          <li><Link to="/login">Войти</Link></li>
        </ul>
      </nav>
    </header>
  );
};

export default Header;