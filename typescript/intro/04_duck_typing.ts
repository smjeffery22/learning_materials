console.log('Hello');

// interface IUser {
//   username: string;
//   password: string;
// };

// types are immutable and cannot be extended
// interfaces used more => more flexible
type IUser = {
  username: string;
  password: string;
};

const login = (user: IUser): boolean => {
  // user.moreStuff // not accessible because the IUser doesn't have a key called moreStuff
  return true
};

const user = {
  username: 'smjeffery',
  password: '1234',
  moreStuff: true,
};

// below works because user variable has the same structure as IUser
login(user);