import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import Toolbar from '@material-ui/core/Toolbar';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';

const useStyles = makeStyles((theme) => ({
  toolbar: {
    borderBottom: `1px solid ${theme.palette.divider}`,
    },
  toolbarTitle: {
    flex: 1,
  },
  toolbarSecondary: {
    justifyContent: 'space-between',
    overflowX: 'auto',
  },
  toolbarLink: {
    padding: theme.spacing(1),
    flexShrink: 0,
  },
}));

export default function Header(props) {
  const classes = useStyles();
  return (
    <React.Fragment>
      <Toolbar className={classes.toolbar}>
        <Button id="HomeBtn" size="small">Home</Button>
        <Typography 
          fontFamily="'Galada', cursive"
          variant="h3" 
          component="h2"
          color="inherit"
          align="center"

          noWrap
          className={classes.toolbarTitle}>
        News Portal
        </Typography>
        <Button id="SignInBtn" variant="outlined" size="small" >
          Sign in
        </Button>
      </Toolbar>
    </React.Fragment>
  );
}

Header.propTypes = {
  sections: PropTypes.array,
  title: PropTypes.string,
};