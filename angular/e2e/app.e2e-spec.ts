import { ABPNetCoreTemplatePage } from './app.po';

describe('ABPNetCore App', function() {
  let page: ABPNetCoreTemplatePage;

  beforeEach(() => {
    page = new ABPNetCoreTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
