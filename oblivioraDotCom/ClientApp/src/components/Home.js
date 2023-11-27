import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
        <div>
        <p>This is currently a page for hosting utilities etc. that I want more easily accessible for myself. Might make it something more useful in the future.</p>
            <h1>Game Utilities</h1>
            <p><a href="/engageRandom">Fire Emblem: Engage randomizer</a> - A randomizer for selecting units and emblems in Fire Emblem: Engage</p>
      </div>
    );
  }
}
