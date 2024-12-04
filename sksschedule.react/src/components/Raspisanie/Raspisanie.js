


import React from 'react';
import './Raspisanie.css';

function Raspisanie () {
    return (
    
        <div className='menu'>
        <ul>
          <li><a href="/">Главная</a></li>
          <li><a href="/users/">Пользователи</a></li>
          <li><a href="/editor/">Редактор</a></li>
          <ul>
            <li><a href="/punct_1/">Пункт 1</a></li>
          </ul>
          <li><a href="/testing/">Тестирование</a></li>
          <li><a href="/results/">Результаты</a></li>
        </ul>
      </div>
          
    );
}


export default Raspisanie;

