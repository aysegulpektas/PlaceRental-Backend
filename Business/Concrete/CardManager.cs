using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        public IResult Add(Card card)
        {
            if (card.CardNumber.Length < 16)
            {
                return new ErrorResult(Messages.CardNumberInvalid);
            }
            _cardDal.Add(card);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IResult DeleteById(int cardId)
        {
            Card card = _cardDal.Get(c => c.CardId == cardId);
            _cardDal.Delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(), Messages.CardsListed);
        }


        public IDataResult<List<Card>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(p => p.UserId == id));
        }

        public IDataResult<Card> GetById(int cardId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(p => p.CardId == cardId));
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.CardUpdated);
        }
    }
}
