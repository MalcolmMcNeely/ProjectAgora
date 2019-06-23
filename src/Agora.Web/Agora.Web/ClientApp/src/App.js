import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import Posts from './components/Posts';
import PostForm from './components/PostForm';

export default () => (
  <Layout>
    <Route path='/' component={PostForm} />
    <Route path='/' component={Posts} />
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
  </Layout>
);
