import React from 'react';
import './index.css';
import Form from '../../components/Form/Form';
import Container from '../../components/Container/Container';

const AuthPage: React.FC = () => {
  return (
    <div className='authpage'>
      <Container>
        <Form/>
      </Container>
    </div>
  )
}

export default AuthPage;