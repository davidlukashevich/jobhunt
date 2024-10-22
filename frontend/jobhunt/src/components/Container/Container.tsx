import React from 'react';
import './index.css';

interface ContainerInterface {
    children: React.ReactNode;
}

const Container: React.FC<ContainerInterface> = (props) => {
  return (
    <div className='container'>{props.children}</div>
  )
}

export default Container;
