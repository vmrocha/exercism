class TwoFer

  def self.two_fer(name = 'you')
    'One for %<name>s, one for me.' % { name: name }
  end

end

if defined? Minitest

  describe 'Additional Mentor Tests' do

    it 'must use "" when given as a name' do
      expected = 'One for , one for me.'
      actual = TwoFer.two_fer('')
      expect(actual).must_equal expected
    end

    it 'must use {} when given as a name' do
      expected = 'One for {}, one for me.'
      actual = TwoFer.two_fer({})
      expect(actual).must_equal expected
    end

    it 'must use [] when given as a name' do
      expected = 'One for [], one for me.'
      actual = TwoFer.two_fer([])
      expect(actual).must_equal expected
    end

    it 'must use nil when given as a name' do
      expected = 'One for , one for me.'
      actual = TwoFer.two_fer(nil)
      expect(actual).must_equal expected
    end

  end

end
