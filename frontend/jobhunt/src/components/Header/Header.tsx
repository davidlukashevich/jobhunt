import React from 'react';
import { Link } from 'react-router-dom';
import './index.css';
import Container from '../Container/Container';

const Header: React.FC = () => {
  return (
    <header className='header'>
      <Container>
        <ul className='menu-list'>
          <li className='menu-item'>
            <Link className='menu-link' to={'/'}>
              JobHunt
            </Link>
          </li>
          <li className='menu-item'>
            <Link className='menu-link' to={'/auth'}>
              Sing up/Log in
            </Link>
          </li>
        </ul>
      </Container>
    </header>
  )
}

export default Header;
