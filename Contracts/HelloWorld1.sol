// SPDX-License-Identifier: MIT
pragma solidity >=0.6.12 <0.9.0;

contract HelloWorld {

  address wallet;

  mapping(address => bool) private rewardAvailable;

  function Claim() public {
    require(rewardAvailable[msg.sender], "You're not the owner");
    payable(msg.sender).transfer(1 ether);
  }

  function BecomeOwner() public{
    rewardAvailable[msg.sender] = true;
  }
}
      