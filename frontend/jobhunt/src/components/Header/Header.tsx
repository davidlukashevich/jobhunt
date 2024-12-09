import React, { useContext, useEffect } from 'react';
import { Link } from 'react-router-dom';
import './index.css';
import Container from '../Container/Container';
import UserDataContext from '../UserDataMode/UserDataMode';

const Header: React.FC = () => {
  const context = useContext(UserDataContext);

  if (!context) {
    throw new Error('Component must be used within a Provider');
  }

  const { imageUrl, name } = context;

  return (
    <header className='header'>
      <Container>
        <ul className='menu-list'>
          <li className='menu-item'>
            <Link className='menu-link' to={'/'}>
              <div className={name ? 'menu-title' : ''}>JobHunt</div>
            </Link>
          </li>
          <li className='menu-item'>
            {!name ? 
            <Link className='menu-login' to={'/auth'}>
              <div className='menu-title-login'>Sing up/Log in</div>
            </Link> : <Link to={'/myprofile'} className='profile-link'><div className='profile-block'><img src={imageUrl as string} className='profile-img' /><p className='profile-title'>{name}</p></div></Link>}
          </li>
        </ul>
      </Container>
    </header>
  )
}

export default Header;
